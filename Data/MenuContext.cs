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

            modelBuilder.Entity<DishIngredient>()
                .HasOne(d => d.Dish)
                .WithMany(di => di.DishIngredients)
                .HasForeignKey(d => d.DishId);

            modelBuilder.Entity<DishIngredient>()
                .HasOne(i => i.Ingredient)
                .WithMany(di => di.DishIngredients)
                .HasForeignKey(i => i.IngredientId);

            // Seed data for Dishes
            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    id = 1,
                    Name = "Margherita",
                    Price = 7.5,
                    ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfMhxMPgFmcc_yYgHJ_odtNReUO1h2bTBtrq3icPHGWw_cHUVwihJqOIhTrV9-l1_g5-c&usqp=CAU"
                }
            );

            // Correct seed data for Ingredients
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { id = 1, Name = "Tomato Sauce" },
                new Ingredient { id = 2, Name = "Mozzarella" }
            );

            // Seed data for DishIngredients (junction table)
            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient { DishId = 1, IngredientId = 1 },
                new DishIngredient { DishId = 1, IngredientId = 2 }
            );

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<DishIngredient> DishIngredients { get; set; }
    }
}
