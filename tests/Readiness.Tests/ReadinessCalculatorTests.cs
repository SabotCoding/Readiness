using Readiness.Core;

namespace Readiness.Tests;

public class ReadinessCalculatorTests

{
    private const int TwelveMonths = 12;
    [Theory] //First Date is date completed, second date is today
    [InlineData("2026-08-09", "2026-10-09", ReadinessStatus.Green)] // Test Parameters for Green Status
    [InlineData("2025-12-08", "2026-10-09", ReadinessStatus.Green)] // Test Parameters for Green Status at 60 days
    [InlineData("2025-12-07", "2026-10-09", ReadinessStatus.Amber)] // Test Parameters for Amber Status at 59 days
    [InlineData("2025-10-10", "2026-10-09", ReadinessStatus.Amber)] // Test Parameters for Amber Status at 1 day
    [InlineData("2025-10-09", "2026-10-09", ReadinessStatus.Red)] // Test Parameters for Red Status at 0
    [InlineData("2025-09-29", "2026-10-09", ReadinessStatus.Red)] // 10 days overdue
    [InlineData(null, "2026-10-09", ReadinessStatus.Red)] // never completed

    public void GetStatus_ReturnsExpectedStatus(string? lastCompleted, string today, ReadinessStatus expected)
    {
        DateOnly? completed = lastCompleted is null ? null : DateOnly.Parse(lastCompleted);

        var result = ReadinessCalculator.GetStatus(completed, TwelveMonths, DateOnly.Parse(today));

        Assert.Equal(expected, result);
    }

}