using eShopSolution.ViewModel.Common;
using eShopSolution.ViewModel.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
