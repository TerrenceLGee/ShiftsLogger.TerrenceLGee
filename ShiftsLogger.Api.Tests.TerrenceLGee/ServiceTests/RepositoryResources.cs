using ShiftsLogger.Api.TerrenceLGee.Models;
using ShiftsLogger.Api.TerrenceLGee.Shared.Pagination;
using ShiftsLogger.Api.TerrenceLGee.Shared.Parameters;

namespace ShiftsLogger.Api.Tests.TerrenceLGee.ServiceTests;

public static class RepositoryResources
{
    public static readonly string UserId = "2eaf6d3e-a124-40c0-ab8d-d2d0d0231ed3";
    public static readonly int ShiftId = 1;

    public static Shift GetShiftAfterShiftAddSuccess()
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

    public static Shift GetShiftAfterShiftUpdateSuccess()
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

    public static Shift GetShift()
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

    public static PagedList<Shift> GetPagedListOfShifts(PaginationParams paginationParams)
    {
        var shiftId = ShiftId;

        var shifts = new List<Shift>
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

        return new PagedList<Shift>(shifts, count, paginationParams.Page, paginationParams.PageSize);
    }
}
