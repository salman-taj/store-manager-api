using Microsoft.AspNetCore.Mvc;
using StoreManager.Application.Abstractions.Services.Identity;
using StoreManager.Application.Auditing;

namespace StoreManager.Host.Controllers.Identity
{
    [ApiController]
    [Route("api/audit-logs")]
    public class AuditLogsController : ControllerBase
    {
        private readonly ICurrentUser _user;
        private readonly IAuditService _auditService;

        public AuditLogsController(IAuditService auditService, ICurrentUser user)
        {
            _auditService = auditService;
            _user = user;
        }

        [HttpGet]
        public async Task<IActionResult> GetMyLogsAsync()
        {
            return Ok(await _auditService.GetUserTrailsAsync(_user.GetUserId()));
        }
    }
}