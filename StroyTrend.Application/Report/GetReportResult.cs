using StroyTrend.Application.Report.Dto;

namespace StroyTrend.Application.Report;

public class GetReportResult
{
    public string Name { get;  set; }
    public RequestDto Request { get;  set; }
    public int Total { get;  set; }
    
    public Dictionary<string, Dictionary<string, string>> Records { get;  set; } 
}