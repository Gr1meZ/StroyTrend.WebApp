using System.Text.Json.Serialization;
using StroyTrend.Domain.Seed;

namespace StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects.Records;

public class DurationRecord : ValueObject, IRecord
{
    public DurationRecord(int agentsChattingDuration, int count, int duration)
    {
        AgentsChattingDuration = agentsChattingDuration;
        Count = count;
        Duration = duration;
    }
    
    [JsonPropertyName("agents_chatting_duration")]
    public int AgentsChattingDuration { get; private set; }
    public int Count { get; private set; }
    public int Duration { get; private set; }
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return AgentsChattingDuration;
        yield return Count;
        yield return Duration;
    }
}