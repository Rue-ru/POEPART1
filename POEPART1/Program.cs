using System;
namespace POE_part1
{
    public class Program
    {

        static void Main(string[] args)
        {
            int noOfIngredients;
            String ingredientName;
            int quantity;
            int recipeUnitsofMeasure;
            int recipeSteps;
            string description;

            Console.WriteLine("Enter the number of ingredients you would like to enter");
            noOfIngredients = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noOfIngredients; i++)
            {

                Console.WriteLine("Enter the ingredients name with capital letters");
                //enter the ingredients you want 
                ingredientName = Console.ReadLine();

                Console.WriteLine("Enter the ingredients quantity");
                quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the unit of measurement");
                recipeUnitsofMeasure = Console.ReadLine();

            }

            Console.WriteLine("Enter the number of steps you would like to add");
            recipeSteps = Convert.ToInt32(Console.ReadLine());

            for (int b = 0; b < recipeSteps; b++)
            {
                Console.WriteLine("Please enter your steps one by one in order");
                string steps = Console.ReadLine();
            }
        }

    }
}