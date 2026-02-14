using ShiftsLogger.Client.TerrenceLGee.Models;
using ShiftsLogger.Client.TerrenceLGee.Services.Interfaces;
using ShiftsLogger.Client.TerrenceLGee.ShiftsLoggerUI.Helpers;
using ShiftsLogger.Client.TerrenceLGee.ShiftsLoggerUI.Interfaces;
using ShiftsLogger.Contracts.TerrenceLGee.DTOs.AuthDTOs;
using Spectre.Console;

namespace ShiftsLogger.Client.TerrenceLGee.ShiftsLoggerUI;

public class AuthUi : IAuthUi
{
    private readonly IAuthService _authService;

    public AuthUi(IAuthService authService)
    {
        _authService = authService;
    }

    public Task RegisterUserAsync()
    {
        throw new NotImplementedException();
    }

    public Task<AuthData?> LoginAsync()
    {
        throw new NotImplementedException();
    }

    public Task LogoutAsync(AuthData authData)
    {
        throw new NotImplementedException();
    }
}
