using StroyTrend.Domain.Seed;

namespace StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects;

public class Group : ValueObject
{
    public Group(List<int> values)
    {
        Values = values;
    }

    public List<int> Values { get; private set; }

    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Values;
    }
}