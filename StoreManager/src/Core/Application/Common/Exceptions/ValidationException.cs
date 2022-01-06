using System.Net;

namespace StoreManager.Application.Exceptions
{
    public class ValidationException : CustomException
    {
        public ValidationException(List<string> errors = default)
            : base("Validation Failures Occured.", errors, HttpStatusCode.BadRequest)
        {
        }
    }
}