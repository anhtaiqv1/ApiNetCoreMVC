using eShopSolution.ViewModel.Catalog.Categories;
using eShopSolution.ViewModel.Common;
using eShopSolution.ViewModel.System.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
    }
}