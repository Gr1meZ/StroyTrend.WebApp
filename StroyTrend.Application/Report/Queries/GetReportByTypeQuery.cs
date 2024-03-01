using StroyTrend.Application.Configuration.Queries;
using StroyTrend.Application.SeedPaging;
using StroyTrend.Domain.Aggregates.ReportAggregate;

namespace StroyTrend.Application.Report.Queries;

public class GetReportByTypeQuery : PagedRequest, IQuery<GetReportResult>
{
    public ReportType ReportType { get; private set; }
    public string ContentPath { get; private set; }
    
    public GetReportByTypeQuery(ReportType reportType, string contentPath)
    {
        ReportType = reportType;
        ContentPath = contentPath;
    }
}