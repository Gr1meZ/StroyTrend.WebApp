using System.Text.Json;
using AutoMapper;
using Newtonsoft.Json.Linq;
using StroyTrend.Application.Configuration.Queries;
using StroyTrend.Application.Report.Dto;
using StroyTrend.Application.Report.Queries;
using StroyTrend.Application.SeedPaging;
using StroyTrend.Domain.Aggregates.ReportAggregate;
using StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects.Records;

namespace StroyTrend.Application.Report.Handlers;

public class GetReportHandler : IQueryHandler<GetReportByTypeQuery, GetReportResult>
{
    private readonly IMapper _mapper;

    public GetReportHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<GetReportResult> Handle(GetReportByTypeQuery request, CancellationToken cancellationToken)
    {
        var path = GetPathByType(request.ReportType, request.ContentPath);
        var report = await Domain.Aggregates.ReportAggregate.Report.DeserializeJsonToReport(path);
        
        report.FilterRecordsByDate(request.Date);
        var result = _mapper.Map<GetReportResult>(report);
        return result;
    }
    
    private string GetPathByType(ReportType reportType, string contentPath)
    {
        return reportType switch
        {
            ReportType.Duration => Path.Combine(contentPath, "duration.json"),
            ReportType.Ratings => Path.Combine(contentPath, "ratings.json"),
            ReportType.ResponseTime => Path.Combine(contentPath, "responseTime.json"),
            ReportType.Tags => Path.Combine(contentPath, "tags.json"),
            ReportType.TotalChats => Path.Combine(contentPath, "totalChats.json"),
            _ => throw new ArgumentOutOfRangeException(nameof(reportType), reportType, null)
        };
    }
    
}