using System.Text;

namespace CopperSharp.Utils;

/// <summary>
///     An ASCII progress bar
/// </summary>
public class ProgressBar : IDisposable, IProgress<double>
{
    private const int BlockCount = 10;
    private const string Animation = @"|/-\";
    private readonly TimeSpan _animationInterval = TimeSpan.FromSeconds(1.0 / 8);

    private readonly Timer _timer;
    private int _animationIndex;

    private double _currentProgress;
    private string _currentText = string.Empty;
    private bool _disposed;

    /// <summary>
    ///     Constructs a new progress bar
    /// </summary>
    public ProgressBar()
    {
        _timer = new Timer(TimerHandler!);

        // A progress bar is only for temporary display in a console window.
        // If the console output is redirected to a file, draw nothing.
        // Otherwise, we'll end up with a lot of garbage in the target file.
        if (!Console.IsOutputRedirected) ResetTimer();
    }

    /// <summary>
    ///     Disposes this progress bar
    /// </summary>
    public void Dispose()
    {
        GC.SuppressFinalize(this);
        lock (_timer)
        {
            _disposed = true;
            UpdateText(string.Empty);
        }
    }

    /// <summary>
    ///     Reports progress for this bar
    /// </summary>
    /// <param name="value">Progress to be reported</param>
    public void Report(double value)
    {
        value = Math.Clamp(value, 0d, 1d);
        Interlocked.Exchange(ref _currentProgress, value);
    }

    private void TimerHandler(object state)
    {
        lock (_timer)
        {
            if (_disposed) return;

            var progressBlockCount = (int) (_currentProgress * BlockCount);
            var percent = (int) (_currentProgress * 100);
            var text =
                $"[{new string('#', progressBlockCount)}{new string('-', BlockCount - progressBlockCount)}] {percent,3}% {Animation[_animationIndex++ % Animation.Length]}";
            UpdateText(text);

            ResetTimer();
        }
    }

    private void UpdateText(string text)
    {
        // Get length of common portion
        var commonPrefixLength = 0;
        var commonLength = Math.Min(_currentText.Length, text.Length);
        while (commonPrefixLength < commonLength && text[commonPrefixLength] == _currentText[commonPrefixLength])
            commonPrefixLength++;

        // Backtrack to the first differing character
        var outputBuilder = new StringBuilder();
        outputBuilder.Append('\b', _currentText.Length - commonPrefixLength);

        // Output new suffix
        outputBuilder.Append(text.AsSpan(commonPrefixLength));

        // If the new text is shorter than the old one: delete overlapping characters
        var overlapCount = _currentText.Length - text.Length;
        if (overlapCount > 0)
        {
            outputBuilder.Append(' ', overlapCount);
            outputBuilder.Append('\b', overlapCount);
        }

        Console.Write(outputBuilder);
        _currentText = text;
    }

    private void ResetTimer()
    {
        _timer.Change(_animationInterval, TimeSpan.FromMilliseconds(-1));
    }
}