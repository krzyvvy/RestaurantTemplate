using RestaurantTemplate_API1.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Services
{
    public interface ICategoryService
    {
        Task AddCategory(CategoryInformation categoryInformation);
        Task<CategoryInformation> GetCategory(int id);
        Task<IEnumerable<CategoryInformation>> GetCategories();
        Task EditCategory(CategoryInformation categoryInformation);
        Task DeleteCategory(int id);
    }
}
