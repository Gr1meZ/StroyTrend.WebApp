namespace StroyTrend.Application.SeedPaging;

public class SpecificationResult<TReport> 
{
    public SpecificationResult(Dictionary<string, Dictionary<string, string>> data, int total)
    {
        Data = data;
        Total = total;
    }

    public Dictionary<string, Dictionary<string, string>> Data { get; }
    public int Total { get; }
}