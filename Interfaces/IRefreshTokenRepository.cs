using System.Text;
using System;
using TestingPlatform.Application.Dtos;
using TestingPlatform.Domain.Models;

namespace TestingPlatform.Application.Interfaces;

public interface IRefreshTokenRepository
{
    Task SaveRefreshTokenAsync(int userId, string tokenRaw, DateTime expiresAt);
    Task<RefreshTokenDto> RevokeTokenAsync(string tokenRaw);
}
