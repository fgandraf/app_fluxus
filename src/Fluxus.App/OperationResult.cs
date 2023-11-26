
namespace Fluxus.App
{

    public class OperationResult
    {
        public bool Success { get; protected set; }
        public string? Message { get; protected set; }

        public OperationResult(bool success = false, string? message = null)
        {
            Success = success;
            Message = message;
        }

        public static OperationResult SuccessResult() => new OperationResult ( success : true );
        public static OperationResult FailureResult(string message) => new OperationResult ( success : false, message : message );
    }


    public class OperationResult<T> : OperationResult
    {
        public T? Value { get; private set; }

        protected OperationResult(bool success, T? value = default, string? message = null) : base(success, message)
            => Value = value;

        public static OperationResult<T> SuccessResult(T model) => new OperationResult<T>(true, model);
        public static new OperationResult<T> FailureResult(string message) => new OperationResult<T>(false, default, message);
    }

}
