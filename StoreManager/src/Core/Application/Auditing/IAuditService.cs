using StoreManager.Application.Common.Interfaces;
using StoreManager.Application.Wrapper;
using StoreManager.Shared.DTOs.Auditing;

namespace StoreManager.Application.Auditing
{
    public interface IAuditService : ITransientService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetUserTrailsAsync(Guid userId);
    }
}