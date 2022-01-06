using Mapster;
using Microsoft.EntityFrameworkCore;
using StoreManager.Application.Auditing;
using StoreManager.Application.Wrapper;
using StoreManager.Infrastructure.Persistence.Contexts;
using StoreManager.Shared.DTOs.Auditing;

namespace StoreManager.Infrastructure.Auditing
{
    public class AuditService : IAuditService
    {
        private readonly ApplicationDbContext _context;

        public AuditService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IResult<IEnumerable<AuditResponse>>> GetUserTrailsAsync(Guid userId)
        {
            var trails = await _context.AuditTrails.Where(a => a.UserId == userId).OrderByDescending(a => a.Id).Take(250).ToListAsync();
            var mappedLogs = trails.Adapt<IEnumerable<AuditResponse>>();
            return await Result<IEnumerable<AuditResponse>>.SuccessAsync(mappedLogs);
        }
    }
}