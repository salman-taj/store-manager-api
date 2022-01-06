using StoreManager.Application.Common.Interfaces;
using StoreManager.Application.Wrapper;
using StoreManager.Shared.DTOs.Identity;

namespace StoreManager.Application.Abstractions.Services.Identity
{
    public interface IRoleService : ITransientService
    {
        Task<Result<List<RoleDto>>> GetListAsync();

        Task<Result<List<PermissionDto>>> GetPermissionsAsync(string id);

        Task<int> GetCountAsync();

        Task<Result<RoleDto>> GetByIdAsync(string id);

        Task<Result<string>> RegisterRoleAsync(RoleRequest request);

        Task<Result<string>> DeleteAsync(string id);

        Task<Result<List<RoleDto>>> GetUserRolesAsync(string userId);

        Task<Result<string>> UpdatePermissionsAsync(string id, List<UpdatePermissionsRequest> request);
    }
}