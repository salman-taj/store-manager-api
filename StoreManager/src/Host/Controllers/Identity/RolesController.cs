using Microsoft.AspNetCore.Mvc;
using StoreManager.Application.Abstractions.Services.Identity;
using StoreManager.Domain.Constants;
using StoreManager.Infrastructure.Identity.Permissions;
using StoreManager.Shared.DTOs.Identity;

namespace StoreManager.Host.Controllers.Identity
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet("all")]
        [MustHavePermission(PermissionConstants.Roles.ListAll)]
        public async Task<IActionResult> GetListAsync()
        {
            var roles = await _roleService.GetListAsync();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        [MustHavePermission(PermissionConstants.Roles.View)]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var roles = await _roleService.GetByIdAsync(id);
            return Ok(roles);
        }

        [HttpGet("{id}/permissions")]
        public async Task<IActionResult> GetPermissionsAsync(string id)
        {
            var roles = await _roleService.GetPermissionsAsync(id);
            return Ok(roles);
        }

        [HttpPut("{id}/permissions")]
        public async Task<IActionResult> UpdatePermissionsAsync(string id, List<UpdatePermissionsRequest> request)
        {
            var roles = await _roleService.UpdatePermissionsAsync(id, request);
            return Ok(roles);
        }

        [HttpPost]
        [MustHavePermission(PermissionConstants.Roles.Register)]
        public async Task<IActionResult> RegisterRoleAsync(RoleRequest request)
        {
            var response = await _roleService.RegisterRoleAsync(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        [MustHavePermission(PermissionConstants.Roles.Remove)]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var response = await _roleService.DeleteAsync(id);
            return Ok(response);
        }
    }
}