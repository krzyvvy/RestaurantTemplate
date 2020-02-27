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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CategoryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddCategory(CategoryInformation categoryInformation)
        {
            var category = _mapper.Map<Category>(categoryInformation);
            await _context.AddAsync(category);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);
            _context.Remove(category);

            await _context.SaveChangesAsync();
        }

        public async Task EditCategory(CategoryInformation categoryInformation)
        {
            var category = _mapper.Map<Category>(categoryInformation);
            _context.Update(category);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryInformation>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return _mapper.Map<IEnumerable<CategoryInformation>>(categories);
        }

        public async Task<CategoryInformation> GetCategory(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);
            return _mapper.Map<CategoryInformation>(category);
        }
    }
}
