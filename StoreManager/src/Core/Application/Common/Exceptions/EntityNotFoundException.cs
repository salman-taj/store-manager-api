using System.Net;

namespace StoreManager.Application.Exceptions
{
    public class EntityNotFoundException : CustomException
    {
        public EntityNotFoundException(string message)
        : base(message, null, HttpStatusCode.NotFound)
        {
        }
    }
}