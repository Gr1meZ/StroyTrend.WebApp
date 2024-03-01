namespace StroyTrend.Application.Report.Dto;

public class FilterDto
{
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public GroupDto Groups { get; set; }
}