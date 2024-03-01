using AutoMapper;
using StroyTrend.Application.Report;
using StroyTrend.Application.Report.Dto;
using StroyTrend.Domain.Aggregates.ReportAggregate.ValueObjects;

namespace StroyTrend.Application.Configuration.AutoMapper;

public class ApplicationProfile : Profile
{
    public ApplicationProfile()
    {
        CreateMap<Request, RequestDto>();
        CreateMap<Filter, FilterDto>();
        CreateMap<Group, GroupDto>();
        CreateMap<Domain.Aggregates.ReportAggregate.Report, GetReportResult>();
    }
}