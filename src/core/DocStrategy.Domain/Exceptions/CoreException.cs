namespace DocStrategy.Domain.Exceptions;

public class CoreException
    : Exception
{
    protected CoreException(CoreExceptionModel coreError)
        : base(
            coreError?.Message,
            coreError?.InnerException)
    {
        ArgumentNullException.ThrowIfNull(coreError);

        CoreError = coreError;
    }

    public CoreExceptionModel CoreError { get; }
}


public class CoreExceptionModel(string key, string message, Exception? innerException = null)
{
    public string? Key { get; set; } = key;

    public string? Message { get; set; } = message;

    public Exception? InnerException { get; set; } = innerException;
}