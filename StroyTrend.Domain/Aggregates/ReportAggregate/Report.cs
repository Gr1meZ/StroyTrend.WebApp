using System.Text.Json;
using System.Text.Json.Serialization;
using StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects;
using StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects.Records;
using StroyTrend.Domain.Seed;

namespace StroyTrend.Domain.Aggregates.ReportAggregate;

public class Report
{
    public Report(string name, Request request, int total, Dictionary<string, Dictionary<string, string>> records)
    {
        Name = name;
        Request = request;
        Total = total;
        Records = records;
    }
    public string Name { get; private set; }
    public Request Request { get; private set; }
    public int Total { get; private set; }
    public Dictionary<string, Dictionary<string, string>> Records { get; private set; } 

    public static async Task<Report> DeserializeJsonToReport(string path) 
    {
        var json = await File.ReadAllTextAsync(path);
        
        var options = new JsonSerializerOptions { 
            Converters = { new NumberToStringConverter() },
            AllowTrailingCommas = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };
        
        var report = JsonSerializer.Deserialize<Report>(json, options);
        
        if (report == null)
        {
            throw new InvalidOperationException($"Unable to deserialize the report from the path: {path}");
        }

        return report;
    }
}