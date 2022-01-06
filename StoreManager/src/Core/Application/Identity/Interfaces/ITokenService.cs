using StoreManager.Application.Common.Interfaces;
using StoreManager.Application.Wrapper;
using StoreManager.Shared.DTOs.Identity;

namespace StoreManager.Application.Abstractions.Services.Identity
{
    public interface ITokenService : ITransientService
    {
        Task<IResult<TokenResponse>> GetTokenAsync(TokenRequest request, string ipAddress);

        Task<IResult<TokenResponse>> RefreshTokenAsync(RefreshTokenRequest request, string ipAddress);
    }
}