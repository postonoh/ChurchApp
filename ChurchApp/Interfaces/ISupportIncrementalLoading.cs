using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ChurchApp.Interfaces
{
    public interface ISupportIncrementalLoading
    {
        int PageSize { get; set; }
        bool IsIncrementalLoading { get; set; }
        bool HasMoreItems { get; set; }
        ICommand LoadMoreItemsCommand { get; }
    }
}
