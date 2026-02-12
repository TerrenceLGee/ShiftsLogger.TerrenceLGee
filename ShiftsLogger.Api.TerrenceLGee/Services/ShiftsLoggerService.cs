using ShiftsLogger.Api.TerrenceLGee.Mappings.ShiftMappings;
using ShiftsLogger.Api.TerrenceLGee.Repositories.Interfaces;
using ShiftsLogger.Api.TerrenceLGee.Services.Interfaces;
using ShiftsLogger.Api.TerrenceLGee.Shared.Pagination;
using ShiftsLogger.Api.TerrenceLGee.Shared.Parameters;
using ShiftsLogger.Api.TerrenceLGee.Shared.Results;
using ShiftsLogger.Contracts.TerrenceLGee.DTOs.ShiftDTOs;

namespace ShiftsLogger.Api.TerrenceLGee.Services;

public class ShiftsLoggerService : IShiftsLoggerService
{
    private readonly IShiftsLoggerRepository _repository;

    public ShiftsLoggerService(IShiftsLoggerRepository repository)
    {
        _repository = repository;
    }

    public async Task<Result<RetrievedShiftDto?>> AddShiftAsync(CreateShiftDto createShiftDto)
    {
        var addedShift = await _repository.AddShiftAsync(createShiftDto.FromCreateShiftDto());

        if (addedShift is null)
        {
            return Result<RetrievedShiftDto?>.Fail("Error adding new shift");
        }

        return Result<RetrievedShiftDto?>.Ok(addedShift.ToRetrievedShiftDto());
    }

    public async Task<Result<RetrievedShiftDto?>> UpdateShiftAsync(UpdateShiftDto updateShiftDto)
    {
        var updatedShift = await _repository.UpdateShiftAsync(updateShiftDto.FromUpdateShiftDto());

        if (updatedShift is null)
        {
            return new Result<RetrievedShiftDto?>($"Error updating shift {updateShiftDto.Id}");
        }

        return new Result<RetrievedShiftDto?>(updatedShift.ToRetrievedShiftDto());
    }

    public async Task<Result> DeleteShiftAsync(UserParams userParams)
    {
        var deletionResult = await _repository.DeleteShiftAsync(userParams);

        if (!deletionResult)
        {
            return Result.Fail($"Error deleting shift {userParams.ShiftId}");
        }

        return Result.Ok();
    }

    public async Task<Result<RetrievedShiftDto?>> GetShiftAsync(UserParams userParams)
    {
        var shift = await _repository.GetShiftAsync(userParams);

        if (shift is null)
        {
            return Result<RetrievedShiftDto?>.Fail($"Error retrieving shift {userParams.ShiftId}");
        }

        return Result<RetrievedShiftDto?>.Ok(shift.ToRetrievedShiftDto());
    }

    public async Task<Result<PagedList<RetrievedShiftDto>>> GetShiftsAsync(PaginationParams paginationParams)
    {
        var shifts =  await _repository.GetShiftsAsync(paginationParams);

        return Result<PagedList<RetrievedShiftDto>>.Ok(shifts.ToPagedListOfRetrievedShiftDto(paginationParams));
    }

    public async Task<Result<PagedList<RetrievedShiftDto>>> GetAllShiftsForAdminAsync(PaginationParams paginationParams)
    {
        var shifts = await _repository.GetAllShiftsForAdminAsync(paginationParams);

        return Result<PagedList<RetrievedShiftDto>>.Ok(shifts.ToPagedListOfRetrievedShiftDto(paginationParams));
    }

    public async Task<Result<int>> GetCountOfShiftsAsync(UserParams userParams)
    {
        var shiftsCount = await _repository.GetCountOfShiftsAsync(userParams);

        if (shiftsCount == -1)
        {
            return Result<int>.Fail("Error retrieving the count of shifts");
        }

        return Result<int>.Ok(shiftsCount);
    }

    public async Task<Result<int>> GetCountOfShiftsForAdminAsync()
    {
        var shiftsCount = await _repository.GetCountOfShiftsForAdminAsync();

        if (shiftsCount == -1)
        {
            return Result<int>.Fail("Error retrieving the count of shifts");
        }

        return Result<int>.Ok(shiftsCount);
    }
}
