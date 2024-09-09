namespace Hospital_Web.Models
{
    public class DishIngredient
    {
        public int id { get; set; }

        public int DishId { get; set; } // Add this property for the foreign key

        public Dish Dish { get; set; }

        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

    }
}
