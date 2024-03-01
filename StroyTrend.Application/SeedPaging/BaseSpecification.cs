
using System.Collections;

namespace StroyTrend.Application.SeedPaging;

public abstract class BaseSpecification
{
    protected string? Search { get; set;}
    protected string OrderColumn { get;  set;}
    protected string OrderDir { get;  set;}
    protected Dictionary<string, Dictionary<string, string>> Data { get;  set; }
    protected int Total { get; set; }

    protected BaseSpecification(Dictionary<string, Dictionary<string, string>> data, string? search, string orderColumn, string orderDir)
    {
        Data = data;
        Search = search?.ToLower();
        OrderColumn = orderColumn;
        OrderDir = orderDir;
    }

    protected abstract void SearchData();
    protected abstract void OrderData();
    protected virtual int GetTotal() => Total = Data.Count;

    public virtual SpecificationResult<Dictionary<string, Dictionary<string, string>>> GetSpecificationResult(int pageNumber, int pageSize)
    {
        var total =  GetTotal();
        Data = Data.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToDictionary();
        return new SpecificationResult<Dictionary<string, Dictionary<string, string>>>(Data, total);
    }
    
}