using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.Common
{
    public class PagingRequestBase 
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
