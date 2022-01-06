using StoreManager.Shared.DTOs.General.Requests;

namespace StoreManager.Application.Common.Interfaces
{
    public interface IMailService : ITransientService
    {
        Task SendAsync(MailRequest request);
    }
}