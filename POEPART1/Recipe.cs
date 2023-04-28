using System;

namespace POEPART1
{
    public class Recipe
    {

        public string IngredientName { get; set; }
        public int Quantity { get; set; }
        public int RecipeUnitsofMeasure { get; set; }
        public int RecipeSteps { get; set; }
        public string Description { get; set; }

        public Recipe(string ingredientName, int quantity, int recipeUnitsofMeasure, string description)
        {
            IngredientName = ingredientName;
            Quantity = quantity;    
            RecipeUnitsofMeasure = recipeUnitsofMeasure;
            Description = description;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
