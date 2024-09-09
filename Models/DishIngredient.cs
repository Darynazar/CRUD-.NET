namespace Hospital_Web.Models
{
    public class DishIngredient
    {
        public int id { get; set; }

        public Dish Dish { get; set; }

        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

    }
}
