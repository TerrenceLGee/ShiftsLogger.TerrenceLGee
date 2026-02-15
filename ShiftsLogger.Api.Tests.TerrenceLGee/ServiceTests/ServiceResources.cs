using ShiftsLogger.Api.TerrenceLGee.Shared.Pagination;
using ShiftsLogger.Api.TerrenceLGee.Shared.Parameters;
using ShiftsLogger.Api.TerrenceLGee.Shared.Results;
using ShiftsLogger.Contracts.TerrenceLGee.DTOs.ShiftDTOs;

namespace ShiftsLogger.Api.Tests.TerrenceLGee.ServiceTests;

public static class ServiceResources
{
    public static readonly string UserId = "2eaf6d3e-a124-40c0-ab8d-d2d0d0231ed3";
    public static readonly int ShiftId = 1;

    public static Result<RetrievedShiftDto?> GetResultFromShiftAddSuccess()
    {
        return Result<RetrievedShiftDto?>.Ok(GetRetrievedShiftDtoAfterAdd());
    }

    public static Result<RetrievedShiftDto?> GetResultFromShiftAddFailure()
    {
        return Result<RetrievedShiftDto?>.Fail("Error adding new shift");
    }

    public static Result<RetrievedShiftDto?> GetResultFromShiftUpdateSuccess()
    {
        return Result<RetrievedShiftDto?>.Ok(GetRetrievedShiftDtoAfterUpdate());
    }

    public static Result<RetrievedShiftDto?> GetResultFromShiftUpdateFailure()
    {
        return Result<RetrievedShiftDto?>.Fail($"Error updating shift {ShiftId}");
    }

    public static Result GetResultFromShiftDeletionSuccess()
    {
        return Result.Ok();
    }

    public static Result GetResultFromShiftDeletionFailure()
    {
        return Result.Fail($"Error deleting shift {ShiftId}");
    }

    public static Result<RetrievedShiftDto?> GetResultFromGetShiftSuccess()
    {
        return Result<RetrievedShiftDto?>.Ok(GetRetrievedShiftDto());
    }

    public static Result<RetrievedShiftDto?> GetResultFromGetShiftFailure()
    {
        return Result<RetrievedShiftDto?>.Fail($"Error retrieving shift {ShiftId}");
    }

    public static CreateShiftDto GetCreateShiftDtoBeforeAdd()
    {
        return new()
        {
            UserId = UserId,
            ShiftStart = DateTime.Parse("02-14-2026 13:30"),
            ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
            Duration = TimeSpan.FromHours(8)
        };
    }

    public static UpdateShiftDto GetUpdateShiftDtoBeforeUpdate()
    {
        return new()
        {
            Id = ShiftId,
            UserId = UserId,
            ShiftStart = DateTime.Parse("02-14-2026 13:30"),
            ShiftEnd = DateTime.Parse("02-14-2026 23:30"),
            Duration = TimeSpan.FromHours(10)
        };
    }

    public static RetrievedShiftDto? GetRetrievedShiftDtoAfterAdd()
    {
        return new()
        {
            Id = ShiftId,
            UserId = UserId,
            ShiftStart = DateTime.Parse("02-14-2026 13:30"),
            ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
            Duration = TimeSpan.FromHours(8)
        };
    }

    public static RetrievedShiftDto? GetRetrievedShiftDtoAfterUpdate()
    {
        return new()
        {
            Id = ShiftId,
            UserId = UserId,
            ShiftStart = DateTime.Parse("02-14-2026 13:30"),
            ShiftEnd = DateTime.Parse("02-14-2026 23:30"),
            Duration = TimeSpan.FromHours(10)
        };
    }

    public static RetrievedShiftDto? GetRetrievedShiftDto()
    {
        return new()
        {
            Id = ShiftId,
            UserId = UserId,
            ShiftStart = DateTime.Parse("02-14-2026 13:30"),
            ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
            Duration = TimeSpan.FromHours(8)
        };
    }

    public static PagedList<RetrievedShiftDto> GetPagedListOfRetrievedShiftDto(PaginationParams paginationParams)
    {
        var shiftId = ShiftId;

        var shifts = new List<RetrievedShiftDto>
        {
            new()
            {
                Id = shiftId++,
                UserId = UserId,
                ShiftStart = DateTime.Parse("02-14-2026 13:30"),
                ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
                Duration = TimeSpan.FromHours(8)
            },
            new()
            {
                Id = shiftId++,
                UserId = UserId,
                ShiftStart = DateTime.Parse("02-14-2026 13:30"),
                ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
                Duration = TimeSpan.FromHours(8)
            },
            new()
            {
                Id = shiftId++,
                UserId = UserId,
                ShiftStart = DateTime.Parse("02-14-2026 13:30"),
                ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
                Duration = TimeSpan.FromHours(8)
            },
            new()
            {
                Id = shiftId++,
                UserId = UserId,
                ShiftStart = DateTime.Parse("02-14-2026 13:30"),
                ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
                Duration = TimeSpan.FromHours(8)
            },
            new()
            {
                Id = shiftId++,
                UserId = UserId,
                ShiftStart = DateTime.Parse("02-14-2026 13:30"),
                ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
                Duration = TimeSpan.FromHours(8)
            },
            new()
            {
                Id = shiftId++,
                UserId = UserId,
                ShiftStart = DateTime.Parse("02-14-2026 13:30"),
                ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
                Duration = TimeSpan.FromHours(8)
            },
            new()
            {
                Id = shiftId++,
                UserId = UserId,
                ShiftStart = DateTime.Parse("02-14-2026 13:30"),
                ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
                Duration = TimeSpan.FromHours(8)
            },
            new()
            {
                Id = shiftId++,
                UserId = UserId,
                ShiftStart = DateTime.Parse("02-14-2026 13:30"),
                ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
                Duration = TimeSpan.FromHours(8)
            },
            new()
            {
                Id = shiftId++,
                UserId = UserId,
                ShiftStart = DateTime.Parse("02-14-2026 13:30"),
                ShiftEnd = DateTime.Parse("02-14-2026 21:30"),
                Duration = TimeSpan.FromHours(8)
            }
        };

        var count = shifts.Count;

        return new PagedList<RetrievedShiftDto>(shifts, count, paginationParams.Page, paginationParams.PageSize);
    }
}
