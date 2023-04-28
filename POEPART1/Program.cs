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

                Console.WriteLine("1. Tsp");
                Console.WriteLine("2. Tbsp");
                Console.WriteLine("3. Gram");
                Console.WriteLine("4. Kilogram ");
                Console.WriteLine("5. Cup");
                Console.WriteLine("6. Millilitre ");
                Console.WriteLine("7. Litre");
                Console.WriteLine("8. Quart");
                Console.WriteLine("9. Pint");
                Console.WriteLine("10. Fl oz ");
                Console.WriteLine("11. Ounce");
                Console.WriteLine("12, Gal");
                Console.WriteLine("13. Pound");
                Console.WriteLine("14. Slices");
                Console.WriteLine("15. Diced");
                Console.WriteLine("16. Large");
                Console.WriteLine("17. Small");
                Console.WriteLine();
                    
                Console.WriteLine("Select from the list below to add the measuring units the ingreadient needs");
                recipeUnitsofMeasure = Convert.ToInt32(Console.ReadLine());

                switch (recipeUnitsofMeasure)
                //switch output will be based on users choice of measurement 
                {
                    case 1:
                        Console.WriteLine(quantity + "tsp");
                        break;
                    case 2:
                        Console.WriteLine(quantity + "Tbsp");
                        break;
                    case 3:
                        Console.WriteLine(quantity + "Gram");
                        break;
                    case 4:
                        Console.WriteLine(quantity + "Kilogram ");
                        break;
                    case 5:
                        Console.WriteLine(quantity + "Cup");
                        break;
                    case 6:
                        Console.WriteLine(quantity + "Millilitre ");
                        break;
                    case 7:
                        Console.WriteLine(quantity + "Litre");
                        break;
                    case 8:
                        Console.WriteLine(quantity + "Quart");
                        break;
                    case 9:
                        Console.WriteLine(quantity + "Pint");
                        break;
                    case 10:
                        Console.WriteLine(quantity + "Fl oz ");
                        break;
                    case 11:
                        Console.WriteLine(quantity + "Ounce");
                        break;
                    case 12:
                        Console.WriteLine(quantity + "Gal");
                        break;
                    case 13:
                        Console.WriteLine(quantity + "Pound");
                        break;
                    case 14:
                        Console.WriteLine(quantity + "Slices");
                        break;
                    case 15:
                        Console.WriteLine(quantity + "Diced");
                        break;
                    case 16:
                        Console.WriteLine(quantity + "Large");
                        break;
                    case 17:
                        Console.WriteLine(quantity + "Small");
                        break;
                }

            }

            Console.WriteLine("Enter the number of steps you would like to add");
            recipeSteps = Convert.ToInt32(Console.ReadLine());

            for (int b = 0; b < recipeSteps; b++)
            {
                Console.WriteLine("Step {0}" , b + 1);

                string steps = Console.ReadLine();
            }

            Console.ReadKey();  
        }

    }
}