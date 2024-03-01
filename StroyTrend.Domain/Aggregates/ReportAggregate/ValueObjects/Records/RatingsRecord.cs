using StroyTrend.Domain.Seed;

namespace StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects.Records;

public class RatingsRecord : ValueObject, IRecord
{
    public RatingsRecord(int bad, int chats, int good)
    {
        Bad = bad;
        Chats = chats;
        Good = good;
    }

    public int Bad { get; private set; }
    public int Chats { get; private set; }
    public int Good { get; private set; }
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Bad;
        yield return Chats;
        yield return Good;
    }
}