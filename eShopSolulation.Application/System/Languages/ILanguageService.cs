using eShopSolution.ViewModel.Common;
using eShopSolution.ViewModel.System.Languages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();

    }
}
