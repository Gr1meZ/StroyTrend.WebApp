using System.Collections;
using StroyTrend.Application.SeedPaging;

namespace StroyTrend.Application.Report;

public sealed class RecordSpecification : BaseSpecification
{
    public RecordSpecification(Dictionary<string, Dictionary<string, string>> orders, string? search, string orderColumn, string orderDir) 
        : base(orders, search, orderColumn, orderDir)
    {
        SearchData();
        OrderData();
    }

    protected override void SearchData()
    {
        if (!string.IsNullOrWhiteSpace(Search))
        {
            Data = Data.Where(f =>
                f.Key.ToLower().Contains(Search.ToLower()) ||
                f.Value.Any(x => x.Value.ToLower().Contains(Search.ToLower()) || x.Key.ToLower().Contains(Search.ToLower()))
            ).ToDictionary(f => f.Key, f => f.Value);
        }

    }

    protected override void OrderData()
    {
        if (!string.IsNullOrWhiteSpace(OrderColumn) && !string.IsNullOrWhiteSpace(OrderDir))
        {
            Data = new Dictionary<string, Dictionary<string, string>>(OrderColumn switch
            {
                "date" => (OrderDir.Equals("asc"))
                    ? Data.OrderBy(o => o.Key)
                    : Data.OrderByDescending(o => o.Key),
                "data" => (OrderDir.Equals("asc"))
                    ? Data.OrderBy(o => o.Value)
                    : Data.OrderByDescending(o => o.Value),
            });
        }
    }
}