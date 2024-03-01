using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StroyTrend.Application.Report.Queries;
using StroyTrend.Domain.Aggregates.ReportAggregate;
using StroyTrend.WebApp.ViewModels;

namespace StroyTrend.WebApp.Controllers;

public class ReportController : Controller
{
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public ReportController(IMediator mediator, IWebHostEnvironment webHostEnvironment, IMapper mapper)
    {
        _mediator = mediator;
        _webHostEnvironment = webHostEnvironment;
        _mapper = mapper;
    }
    
    public async Task<IActionResult> Report(ReportType reportType)
    {
        var getReport = new GetReportByTypeQuery(reportType, Path.Combine(_webHostEnvironment.WebRootPath, "js", "json"));
        var result = await _mediator.Send(getReport);
        var reportViewModel = _mapper.Map<ReportViewModel>(result);
        return View(reportViewModel);
    }
    
    
}