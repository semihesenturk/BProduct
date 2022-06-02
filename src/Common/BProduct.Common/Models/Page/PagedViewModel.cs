﻿namespace BProduct.Common.Models.Page;

public class PagedViewModel<T> where T : class
{
    #region Constructor
    public PagedViewModel() :
        this(new List<T>(), new Page())
    {

    }
    public PagedViewModel(IList<T> results, Page pageInfo)
    {
        Results = results;
        PageInfo = pageInfo;
    }
    #endregion

    public IList<T> Results { get; set; }
    public Page PageInfo { get; set; }
}