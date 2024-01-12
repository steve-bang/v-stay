namespace VStay_Backend.Models.Pageable
{
    /// <summary>
    /// The pageable object.
    /// </summary>
    /// <typeparam name="T">The type of the items.</typeparam>
    public class CPageble <T>
    {
        /// <summary>
        /// The list of the item.
        /// </summary>
        public IEnumerable<T> Items { get; set;} = new List<T>();

        /// <summary>
        /// The Page Number of the pagination.
        /// </summary>
        public int? PageNumber { get; set;}

        /// <summary>
        /// The Page Size of the pagination.
        /// </summary>
        public int? PageSize { get; set;}

        /// <summary>
        /// The Total Items of the pagination.
        /// </summary>
        public long TotalItems { get; set; } = 0;

        /// <summary>
        /// The Total Pages of the pagination.
        /// </summary>
        public int? TotalPages { get; set; }

        /// <summary>
        /// Is the first page of the pagination.
        /// </summary>
        public bool? IsFirstPage { get; set;}

        /// <summary>
        /// Is the last page of the pagination.
        /// </summary>
        public bool? IsLastPage { get; set;}

        #region Constructors

        /// <summary>
        /// Defaults constructor
        /// </summary>
        public CPageble() { }

        /// <summary>
        /// Init the object with items and total items.
        /// </summary>
        /// <param name="items">The list of the items.</param>
        /// <param name="totalItems">The total items.</param>
        public CPageble(List<T> items, long totalItems)
        {
            Items = items;
            TotalItems = totalItems;
        }

        /// <summary>
        /// Creates a new CPageble.
        /// </summary>
        /// <param name="items">The list of the items.</param>
        /// <param name="totalItems">The total items.</param>
        /// <param name="pageNumber">The page number value.</param>
        /// <param name="pageSize">The page size value.</param>
        public CPageble(IEnumerable<T> items, long totalItems, int pageNumber, int pageSize)
        {
            Items = items;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalItems = totalItems;

            // Set properties other by page size, page number and total items
            TotalPages = BuildTotalPage(pageNumber, pageSize);
            IsFirstPage = GetIsFristPage();
            IsLastPage = GetIsFristPage();
        }

        #endregion

        /// <summary>
        /// Build to total page value.
        /// </summary>
        /// <param name="pageSize">The page size.</param>
        /// <param name="totalItems">The total items.</param>
        /// <returns>The total pages.</returns>
        public int BuildTotalPage(int pageSize, long totalItems)
        {
            return (int) ((totalItems - 1) / pageSize) + 1;
        }

        /// <summary>
        /// Gets Is First Page
        /// </summary>
        /// <returns>Return true if the page current is first page</returns>
        public bool? GetIsFristPage()
        {
            if(PageNumber.HasValue && TotalPages.HasValue)
                return PageNumber == 0;
            return null;
                
        }

        /// <summary>
        /// Gets Is Last Page
        /// </summary>
        /// <returns>Return true if the page current is last page</returns>
        public bool? GetIsLastPage()
        {
            if (PageNumber.HasValue && TotalPages.HasValue)
                return PageNumber == TotalPages.Value;
            return null;
        }
    }
}
