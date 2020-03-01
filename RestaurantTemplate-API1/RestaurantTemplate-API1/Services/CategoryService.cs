using RestaurantTemplate_API1.Models.Information;
using RestaurantTemplate_API1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task AddCategory(CategoryInformation categoryInformation)
        {
            await _repository.AddCategory(categoryInformation);
        }

        public async Task DeleteCategory(int id)
        {
            await _repository.DeleteCategory(id);
        }

        public async Task EditCategory(CategoryInformation categoryInformation)
        {
            await _repository.EditCategory(categoryInformation);
        }

        public async Task<IEnumerable<CategoryInformation>> GetCategories()
        {
            return await _repository.GetCategories();
        }

        public async Task<CategoryInformation> GetCategory(int id)
        {
            return await _repository.GetCategory(id);
        }
    }
}
