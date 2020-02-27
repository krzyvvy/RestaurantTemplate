using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantTemplate_API1.Data;
using RestaurantTemplate_API1.Models.Enity;
using RestaurantTemplate_API1.Models.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Repository
{
    public class DishRepository : IDishRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DishRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddDish(DishInformation dishInformation)
        {
            var dish = _mapper.Map<Dish>(dishInformation);
            await _context.AddAsync(dish);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteDish(int id)
        {
            var dish = await _context.Dishes.FirstOrDefaultAsync(x => x.DishId == id);
            await _context.SaveChangesAsync();
        }

        public async Task EditDish(DishInformation dishInformation)
        {
            var dish = _mapper.Map<Dish>(dishInformation);
            _context.Update(dish);

            await _context.SaveChangesAsync();
        }

        public async Task<DishInformation> GetDish(int id)
        {
            var dish = await _context.Dishes.FirstOrDefaultAsync(x => x.DishId == id);
            return _mapper.Map<DishInformation>(dish);
        }

        public async Task<IEnumerable<DishInformation>> GetDishes()
        {
            var dishes = await _context.Dishes.ToListAsync();
            return _mapper.Map<IEnumerable<DishInformation>>(dishes);
        }
    }
}

