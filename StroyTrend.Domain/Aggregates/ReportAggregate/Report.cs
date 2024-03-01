using System.Text.Json;
using StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects;
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
    
    public void FilterRecordsByDate(DateTime date)
    {
        var minDate = new DateTime(2024, 01, 01);
        var maxDate = new DateTime(2024, 01, 14);

        if (date.Date == DateTime.MinValue.Date)
            date = minDate;
        
        if (date.Date == minDate.Date)
        {
            var firstWeek = Records.Where(r => 
                    DateTime.Parse(r.Key) >= minDate && DateTime.Parse(r.Key) 
                    <= new DateTime(2024, 01, 07))
                .OrderBy(r => r.Key).ToDictionary();
            Records = firstWeek;
        }
        else if (date.Date == maxDate.Date)
        {
            var secondWeek = Records.Where(r => 
                    DateTime.Parse(r.Key) > new DateTime(2024, 01, 07) && DateTime.Parse(r.Key) 
                    <= maxDate)
                .OrderBy(r => r.Key).ToDictionary();
            Records = secondWeek;
        }
     
    }

}