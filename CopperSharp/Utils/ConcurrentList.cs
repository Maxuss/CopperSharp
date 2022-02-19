namespace CopperSharp.Utils;

/// <summary>
/// Represents a thread-safe list with several utility methods
/// </summary>
/// <typeparam name="T">Type of element stored in list</typeparam>
public class ConcurrentList<T> : IDisposable
{
    private List<T> _inner = new();
    private readonly ReaderWriterLockSlim _lock = new(LockRecursionPolicy.SupportsRecursion);

    /// <summary>
    /// Adds an element to this list
    /// </summary>
    /// <param name="item">Item to be added</param>
    public void Add(T item)
    {
        _lock.EnterWriteLock();
        try
        {
            _inner.Add(item);
        }
        finally
        {
            if (_lock.IsWriteLockHeld) _lock.ExitWriteLock();
        }
    }

    /// <summary>
    /// Adds multiple items to this list
    /// </summary>
    /// <param name="values">Values to be added</param>
    public void AddRange(params T[] values)
    {
        _lock.EnterWriteLock();
        try
        {
            _inner.AddRange(values);
        }
        finally
        {
            if (_lock.IsWriteLockHeld) _lock.ExitWriteLock();
        }
    }
    
    /// <summary>
    /// Clears this list
    /// </summary>
    public void Clear()
    {
        _lock.EnterWriteLock();
        try
        {
            _inner.Clear();
        }
        finally
        {
            if (_lock.IsWriteLockHeld) _lock.ExitWriteLock();
        }
    }

    /// <summary>
    /// Removes an element from this list
    /// </summary>
    /// <param name="item">Element to be removed</param>
    public void Remove(T item)
    {
        _lock.EnterWriteLock();
        try
        {
            _inner.Remove(item);
        }
        finally
        {
            if (_lock.IsWriteLockHeld) _lock.ExitWriteLock();
        }
    }

    /// <summary>
    /// Removes an element from certain position in this list
    /// </summary>
    /// <param name="at">Position to be cleared</param>
    public void RemoveAt(int at)
    {
        _lock.EnterWriteLock();
        try
        {
            _inner.RemoveAt(at);
        }
        finally
        {
            if(_lock.IsWriteLockHeld) _lock.ExitWriteLock();
        }
    }

    /// <summary>
    /// Counts the amount of elements in this list
    /// </summary>
    public int Count
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _inner.Count;
            }
            finally
            {
                if (_lock.IsReadLockHeld) _lock.ExitReadLock();
            }
        }
    }
    
    /// <summary>
    /// Checks whether this collection has any items
    /// </summary>
    public bool Any() {
        return Count > 0;
    }

    /// <summary>
    /// Accesses this list
    /// </summary>
    /// <param name="at">Position to be acessed</param>
    public T this[int at]
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _inner[at];
            }
            finally
            {
                if(_lock.IsReadLockHeld) _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _inner[at] = value;
            }
            finally
            {
                if(_lock.IsWriteLockHeld) _lock.ExitWriteLock();
            }

        }
    }
    
    /// <inheritdoc />
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    
    /// <summary>
    /// Virtually disposes the list
    /// </summary>
    /// <param name="disposing">Whether the list is disposing</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!disposing) return;
        // ReSharper disable once ConstantConditionalAccessQualifier
        _lock?.Dispose();
    }
    
    /// <summary>
    /// Disposes this concurrent list
    /// </summary>
    ~ConcurrentList()
    {
        Dispose(false);
    }
}