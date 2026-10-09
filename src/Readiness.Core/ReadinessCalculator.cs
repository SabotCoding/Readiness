namespace Readiness.Core;

public static class  ReadinessCalculator
{
    public const int AmberWindowDays = 60;
    public static ReadinessStatus GetStatus(DateOnly? lastCompleted, int intervalMonths, DateOnly today)
    {
        if (lastCompleted is null)
        {
            return ReadinessStatus.Red;
        }

        var dueDate = lastCompleted.Value.AddMonths(intervalMonths);

         if (dueDate <= today)
        {
            return ReadinessStatus.Red;
        }
         if (dueDate.AddDays(-AmberWindowDays) < today)
        {
            return ReadinessStatus.Amber;
        }
            return ReadinessStatus.Green;
    }
}
