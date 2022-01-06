using StoreManager.Application.Common.Interfaces;
using StoreManager.Application.Wrapper;
using StoreManager.Shared.DTOs.Catalog;

namespace StoreManager.Application.Catalog.Interfaces
{
    public interface IBrandService : ITransientService
    {
        Task<PaginatedResult<BrandDto>> SearchAsync(BrandListFilter filter);

        Task<Result<Guid>> CreateBrandAsync(CreateBrandRequest request);

        Task<Result<Guid>> UpdateBrandAsync(UpdateBrandRequest request, Guid id);

        Task<Result<Guid>> DeleteBrandAsync(Guid id);

        Task<Result<string>> GenerateRandomBrandAsync(GenerateRandomBrandRequest request);

        Task<Result<string>> DeleteRandomBrandAsync();
    }
}