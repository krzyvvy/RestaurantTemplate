using RestaurantTemplate_API1.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Services
{
    public interface IDishService
    {
        Task<IEnumerable<DishInformation>> GetDishes();
        Task<DishInformation> GetDish(int id);
        Task AddDish(DishInformation dishInformation);
        Task DeleteDish(int id);
        Task EditDish(DishInformation dishInformation);
    }
}
