using StoreManager.Application.Common.Interfaces;
using StoreManager.Application.Wrapper;
using StoreManager.Shared.DTOs;

namespace StoreManager.Application.Dashboard
{
    public interface IStatsService : ITransientService
    {
        Task<IResult<StatsDto>> GetDataAsync();
    }
}