using StroyTrend.Application.Report;
using StroyTrend.Application.Report.Dto;
using StroyTrend.Application.SeedPaging;
using StroyTrend.Domain.Aggregates.ReportAggregate;
using StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects.Records;

namespace StroyTrend.WebApp.ViewModels;

public class ReportViewModel
{
    public string Name { get;  set; }
    public RequestDto Request { get;  set; }
    public int Total { get;  set; }
    public ReportType ReportType { get; set; }
    public Dictionary<string, Dictionary<string, string>> Records { get;  set; } 
}