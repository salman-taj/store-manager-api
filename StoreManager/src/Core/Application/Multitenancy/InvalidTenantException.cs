using StoreManager.Application.Exceptions;
using System.Net;

namespace StoreManager.Application.Multitenancy
{
    public class InvalidTenantException : CustomException
    {
        public InvalidTenantException(string message)
        : base(message, null, HttpStatusCode.BadRequest)
        {
        }
    }
}