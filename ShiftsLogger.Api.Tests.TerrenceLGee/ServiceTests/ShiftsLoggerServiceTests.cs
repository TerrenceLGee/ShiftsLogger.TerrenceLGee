using Moq;
using ShiftsLogger.Api.TerrenceLGee.Models;
using ShiftsLogger.Api.TerrenceLGee.Repositories.Interfaces;
using ShiftsLogger.Api.TerrenceLGee.Services;

namespace ShiftsLogger.Api.Tests.TerrenceLGee.ServiceTests;

public class ShiftsLoggerServiceTests
{
    private readonly Mock<IShiftsLoggerRepository> _mockRepo;
    private readonly ShiftsLoggerService _shiftsLoggerService;

    public ShiftsLoggerServiceTests()
    {
        _mockRepo = new Mock<IShiftsLoggerRepository>();
        _shiftsLoggerService = new ShiftsLoggerService(_mockRepo.Object);
    }

    [Fact]
    public async Task AddShiftAsync_Returns_ResultWithRetrievedShiftDto_WhenSuccessful()
    {
        var expectedResult = ServiceResources.GetResultFromShiftAddSuccess();

        _mockRepo
            .Setup(r => r.AddShiftAsync(It.IsAny<Shift>()))
            .ReturnsAsync(RepositoryResources.GetShift());

        var actualResult = await _shiftsLoggerService.AddShiftAsync(ServiceResources.GetCreateShiftDtoBeforeAdd());

        Assert.NotNull(actualResult);
        Assert.NotNull(expectedResult);
        Assert.NotNull(actualResult.Value);
        Assert.NotNull(expectedResult.Value);
        Assert.True(actualResult.IsSuccess);
        Assert.False(actualResult.IsFailure);
        Assert.Equal(expectedResult.IsSuccess, actualResult.IsSuccess);
        Assert.Equal(expectedResult.Value.Id, actualResult.Value.Id);
        Assert.Equal(expectedResult.Value.UserId, actualResult.Value.UserId);
        Assert.Equal(expectedResult.Value.ShiftStart, actualResult.Value.ShiftStart);
        Assert.Equal(expectedResult.Value.ShiftEnd, actualResult.Value.ShiftEnd);
        Assert.Equal(expectedResult.Value.Duration, actualResult.Value.Duration);
    }

    [Fact]
    public async Task AddShiftAsync_Returns_ResultWithNull_WhenFailed()
    {
        var expectedResult = ServiceResources.GetResultFromShiftAddFailure();
        Shift? repoReturns = null;

        _mockRepo
            .Setup(r => r.AddShiftAsync(It.IsAny<Shift>()))
            .ReturnsAsync(repoReturns);

        var actualResult = await _shiftsLoggerService.AddShiftAsync(ServiceResources.GetCreateShiftDtoBeforeAdd());

        Assert.NotNull(expectedResult);
        Assert.NotNull(actualResult);
        Assert.Null(expectedResult.Value);
        Assert.Null(actualResult.Value);
        Assert.False(actualResult.IsSuccess);
        Assert.True(actualResult.IsFailure);
    }

    [Fact]
    public async Task UpdateShiftAsync_Returns_ResultWithRetrievedShiftDto_WhenSuccessful()
    {
        var expectedResult = ServiceResources.GetResultFromShiftUpdateSuccess();

        _mockRepo
            .Setup(r => r.UpdateShiftAsync(It.IsAny<Shift>()))
            .ReturnsAsync(RepositoryResources.GetShiftAfterShiftUpdateSuccess());

        var actualResult = await _shiftsLoggerService.UpdateShiftAsync(ServiceResources.GetUpdateShiftDtoBeforeUpdate());

        Assert.NotNull(actualResult);
        Assert.NotNull(expectedResult);
        Assert.NotNull(actualResult.Value);
        Assert.NotNull(expectedResult.Value);
        Assert.True(actualResult.IsSuccess);
        Assert.False(actualResult.IsFailure);
        Assert.Equal(expectedResult.IsSuccess, actualResult.IsSuccess);
        Assert.Equal(expectedResult.Value.Id, actualResult.Value.Id);
        Assert.Equal(expectedResult.Value.UserId, actualResult.Value.UserId);
        Assert.Equal(expectedResult.Value.ShiftStart, actualResult.Value.ShiftStart);
        Assert.Equal(expectedResult.Value.ShiftEnd, actualResult.Value.ShiftEnd);
        Assert.Equal(expectedResult.Value.Duration, actualResult.Value.Duration);
    }
}
