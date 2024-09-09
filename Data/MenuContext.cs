using Microsoft.EntityFrameworkCore;
using Hospital_Web.Models;

namespace Hospital_Web.Data
{
    public class MenuContext: DbContext
    {
        public MenuContext( DbContextOptions<MenuContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(di => new
            {
                di.IngredientId,
                di.DishId,
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
