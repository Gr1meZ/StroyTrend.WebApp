using StroyTrend.Domain.Seed;

namespace StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects.Records;

public class TotalChatsRecord : ValueObject, IRecord
{
    public TotalChatsRecord(int total)
    {
        Total = total;
    }

    public int Total { get; private set; }
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Total;
    }
}