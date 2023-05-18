using eShopSolution.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModel.System.Users
{
    public class GetUserPagingRequest :PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
