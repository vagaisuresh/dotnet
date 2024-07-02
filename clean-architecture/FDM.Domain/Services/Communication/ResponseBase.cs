namespace FDM.Domain.Services.Communication
{
    public abstract class ResponseBase
    {
        public bool Success { get; protected set; }
        public string? Message { get; protected set; }

        public ResponseBase(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}