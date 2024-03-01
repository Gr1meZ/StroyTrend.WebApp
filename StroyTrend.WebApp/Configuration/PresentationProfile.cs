using AutoMapper;
using StroyTrend.Application.Report;
using StroyTrend.WebApp.ViewModels;

namespace StroyTrend.WebApp.Configuration;

public class PresentationProfile : Profile
{
    public PresentationProfile()
    {
        CreateMap<GetReportResult, ReportViewModel>();
    }
}