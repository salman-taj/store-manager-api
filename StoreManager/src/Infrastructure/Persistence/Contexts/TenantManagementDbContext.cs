using Microsoft.EntityFrameworkCore;
using StoreManager.Domain.Multitenancy;

namespace StoreManager.Infrastructure.Persistence.Contexts
{
    public class TenantManagementDbContext : DbContext
    {
        public TenantManagementDbContext(DbContextOptions<TenantManagementDbContext> options)
        : base(options)
        {
        }

        public DbSet<Tenant> Tenants { get; set; }
    }
}