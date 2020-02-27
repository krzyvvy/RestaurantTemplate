using RestaurantTemplate_API1.Models.Information;
using RestaurantTemplate_API1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Services
{
    public class DishService : IDishService
    {
        private readonly IDishRepository _repository;

        public DishService(IDishRepository repository)
        {
            _repository = repository;
        }

        public async Task AddDish(DishInformation dishInformation)
        {
            await _repository.AddDish(dishInformation);
        }

        public async Task DeleteDish(int id)
        {
            await _repository.DeleteDish(id);
        }

        public async Task EditDish(DishInformation dishInformation)
        {
            await _repository.EditDish(dishInformation);
        }

        public async Task<DishInformation> GetDish(int id)
        {
            return await _repository.GetDish(id);
        }

        public async Task<IEnumerable<DishInformation>> GetDishes()
        {
            return await _repository.GetDishes();
        }
    }
}

