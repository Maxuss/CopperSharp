namespace CopperSharp.Functions.Actions;

internal readonly struct FunctionComment : IAction
{
    public FunctionComment(string comment)
    {
        _comment = comment;
    }

    private string _comment { get; }

    public string ToAction()
    {
        return $"# {_comment}";
    }
}