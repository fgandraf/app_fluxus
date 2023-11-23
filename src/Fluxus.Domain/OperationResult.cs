
namespace Fluxus.Domain
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        //public int Id { get; set; }
        public object? Object { get; set; }


        //public static OperationResult SuccessResult(int id = 0) => new OperationResult { Success = true, Id = id };
        public static OperationResult SuccessResult() => new OperationResult { Success = true };

        public static OperationResult SuccessResult(object _object) => new OperationResult { Success = true, Object = _object };
        public static OperationResult FailureResult(string message) => new OperationResult { Success = false, Message = message };
    }
}
