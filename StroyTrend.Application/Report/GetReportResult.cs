using StroyTrend.Application.Report.Dto;
using StroyTrend.Application.SeedPaging;
using StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects.Records;

namespace StroyTrend.Application.Report;

public class GetReportResult
{
    public string Name { get;  set; }
    public RequestDto Request { get;  set; }
    public int Total { get;  set; }
    
    public Dictionary<string, Dictionary<string, string>> Records { get;  set; } 
}