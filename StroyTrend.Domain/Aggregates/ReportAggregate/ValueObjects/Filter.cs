using StroyTrend.Domain.Seed;

namespace StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects;

public class Filter : ValueObject
{
    public Filter(DateTime from, DateTime to, Group groups)
    {
        From = from;
        To = to;
        Groups = groups;
    }
    
    public DateTime From { get; private set; }
    public DateTime To { get; private set; }
    public Group Groups { get; private set; }
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return From;
        yield return To;
        yield return Groups;
    }
}