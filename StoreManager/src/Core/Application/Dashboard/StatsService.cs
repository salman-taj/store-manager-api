using StoreManager.Application.Abstractions.Services.Identity;
using StoreManager.Application.Common.Interfaces;
using StoreManager.Application.Wrapper;
using StoreManager.Domain.Catalog;
using StoreManager.Shared.DTOs;

namespace StoreManager.Application.Dashboard
{
    public class StatsService : IStatsService
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IRepositoryAsync _repository;

        public StatsService(IRepositoryAsync repository, IRoleService roleService, IUserService userService)
        {
            _repository = repository;
            _roleService = roleService;
            _userService = userService;
        }

        public async Task<IResult<StatsDto>> GetDataAsync()
        {
            var stats = new StatsDto
            {
                ProductCount = await _repository.GetCountAsync<Product>(),
                BrandCount = await _repository.GetCountAsync<Brand>(),
                UserCount = await _userService.GetCountAsync(),
                RoleCount = await _roleService.GetCountAsync()
            };
            return await Result<StatsDto>.SuccessAsync(stats);
        }
    }
}