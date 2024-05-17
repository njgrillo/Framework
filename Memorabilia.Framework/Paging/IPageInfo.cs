namespace Memorabilia.Paging;

public interface IPageInfo
{
    int PageNumber { get; set; }

    int PageSize { get; set; }

    int Skip { get; }
}
