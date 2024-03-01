using System.Text.Json.Serialization;
using StroyTrend.Domain.Seed;

namespace StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects.Records;

public class ResponseTimeRecord : ValueObject, IRecord
{
    public int Count { get; private set; }
    [JsonPropertyName("response_time")]
    public double ResponseTime { get; private set; }
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Count;
        yield return ResponseTime;
    }
}