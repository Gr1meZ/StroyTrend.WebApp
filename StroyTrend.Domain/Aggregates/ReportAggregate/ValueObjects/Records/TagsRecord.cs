using System.Text.Json;
using System.Text.Json.Serialization;
using StroyTrend.Domain.Seed;

namespace StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects.Records;

public class TagsRecord : ValueObject, IRecord
{
    public TagsRecord(Dictionary<string, JsonElement> extensionData)
    {
        ExtensionData = extensionData;
    }

    public TagsRecord()
    {
        
    }
    
    [JsonExtensionData]
    public Dictionary<string, JsonElement>? ExtensionData { get; set; }
    protected override IEnumerable<object?> GetEqualityComponents()
    {
        yield return ExtensionData;
    }
}