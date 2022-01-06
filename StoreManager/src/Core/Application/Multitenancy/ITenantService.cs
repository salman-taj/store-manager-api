using StoreManager.Application.Common.Interfaces;
using StoreManager.Shared.DTOs.Multitenancy;

namespace StoreManager.Application.Multitenancy
{
    public interface ITenantService : IScopedService
    {
        public string GetDatabaseProvider();

        public string GetConnectionString();

        public TenantDto GetCurrentTenant();

        public void SetCurrentTenant(string tenant);
    }
}