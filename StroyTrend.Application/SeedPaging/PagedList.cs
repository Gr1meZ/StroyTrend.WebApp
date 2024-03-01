namespace StroyTrend.Application.SeedPaging;

public class PagedList
{
    public PagedList(int pageNumber, int pageSize, int totalItemCount)
    {
        TotalItemCount = totalItemCount;
        PageSize = pageSize;
        PageCount = (TotalItemCount > 0) ? ((int)Math.Ceiling((double)(TotalItemCount) / PageSize)) : 0;
        PageNumber = pageNumber > (PageCount - 1) ? (PageCount - 1) : pageNumber;
        HasPreviousPage = PageNumber > 0;
        HasNextPage = PageNumber < (PageCount - 1);
        IsFirstPage = PageNumber == 0;
        IsLastPage = PageNumber >= (PageCount - 1);
    }
        
    public int PageCount { get; set; }
    public int TotalItemCount { get; set;}
    public int PageNumber { get; set;}
    public int PageSize { get; set;}
    public bool HasPreviousPage { get; set;}
    public bool HasNextPage { get; set;}
    public bool IsFirstPage { get; set;}
    public bool IsLastPage { get; set;}
}
