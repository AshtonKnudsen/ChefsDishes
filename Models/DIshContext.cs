using Microsoft.EntityFrameworkCore;
 
namespace ChefsDishes.Models
{
    public class DishContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DishContext(DbContextOptions<DishContext> options) : base(options) { }
        public DbSet<Chef> Chefs{get;set;}
        public DbSet<Dish> Dishes{get;set;}
    }
}
