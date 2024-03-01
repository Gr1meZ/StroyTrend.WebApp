namespace StroyTrend.Application.SeedPaging;

public class PagedResponse<T> 
{
    public PagedResponse(T items, int totalItemCount, int pageNumber, int pageSize)
    {
        Data = items;
        Metadata = new PagedList(pageNumber, pageSize, totalItemCount);
    }
        
    public PagedList Metadata { get; set; }
    public T Data { get; set; }
}