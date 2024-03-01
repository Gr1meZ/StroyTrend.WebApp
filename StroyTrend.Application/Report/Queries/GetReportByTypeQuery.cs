using StroyTrend.Application.Configuration.Queries;
using StroyTrend.Domain.Aggregates.ReportAggregate;

namespace StroyTrend.Application.Report.Queries;

public class GetReportByTypeQuery :  IQuery<GetReportResult>
{
    public ReportType ReportType { get; private set; }
    public DateTime Date { get; private set; }
    public string ContentPath { get; private set; }
    
    public GetReportByTypeQuery(ReportType reportType, string contentPath, DateTime date)
    {
        ReportType = reportType;
        ContentPath = contentPath;
        Date = date;
    }
}