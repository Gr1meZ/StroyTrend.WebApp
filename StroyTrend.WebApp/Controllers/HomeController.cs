using System.Diagnostics;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StroyTrend.Application;
using StroyTrend.Application.Report.Queries;
using StroyTrend.Domain.Aggregates.ReportAggregate;
using StroyTrend.WebApp.Models;

namespace StroyTrend.WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IMediator _mediator;
    
    public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment, IMediator mediator)
    {
        _logger = logger;
        _webHostEnvironment = webHostEnvironment;
        _mediator = mediator;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}