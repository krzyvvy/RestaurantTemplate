using Microsoft.EntityFrameworkCore;
using RestaurantTemplate_API1.Models.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTemplate_API1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
