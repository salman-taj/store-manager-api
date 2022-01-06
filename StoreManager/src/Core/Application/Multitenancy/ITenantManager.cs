using StoreManager.Application.Common.Interfaces;
using StoreManager.Application.Wrapper;
using StoreManager.Shared.DTOs.Multitenancy;

namespace StoreManager.Application.Multitenancy
{
    public interface ITenantManager : ITransientService
    {
        public Task<Result<TenantDto>> GetByKeyAsync(string key);

        public Task<Result<List<TenantDto>>> GetAllAsync();

        public Task<Result<object>> CreateTenantAsync(CreateTenantRequest request);

        Task<Result<object>> UpgradeSubscriptionAsync(UpgradeSubscriptionRequest request);

        Task<Result<object>> DeactivateTenantAsync(string tenant);

        Task<Result<object>> ActivateTenantAsync(string tenant);
    }
}