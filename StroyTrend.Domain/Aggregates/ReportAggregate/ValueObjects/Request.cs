using StroyTrend.Domain.Seed;

namespace StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects;

public class Request : ValueObject
{
    public Request(string distribution, Filter filters)
    {
        Distribution = distribution;
        Filters = filters;
    }

    public string Distribution { get; set; }
    public Filter Filters { get; set; }
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Distribution;
        yield return Filters;
    }
}