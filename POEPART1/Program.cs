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

                Console.WriteLine("Select from the list below to add the measuring units the ingreadient needs");
                Console.WriteLine("1. tsp");
                Console.WriteLine("2.Tbsp");
                Console.WriteLine("3. Gram");
                Console.WriteLine("4.  Kilogram ");
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

                recipeUnitsofMeasure = Convert.ToInt32(Console.ReadLine());

                switch(recipeUnitsofMeasure)
                    //switch output will be based on users choice of measurement 
                {
                    case 1:
                        Console.WriteLine("tsp");

                        break;
                    case 2:
                        Console.WriteLine("Tbsp");
                        break;
                    case 3:
                        Console.WriteLine("Gram");
                        break;
                    case 4:
                        Console.WriteLine(" Kilogram ");
                        break;
                    case 5:
                        Console.WriteLine("Cup");
                        break;
                    case 6:
                        Console.WriteLine("Millilitre ");
                        break;
                    case 7:
                        Console.WriteLine("Litre");
                        break;
                    case 8:
                        Console.WriteLine("Quart");
                        break;
                    case 9:
                        Console.WriteLine("Pint");
                        break;
                    case 10:
                        Console.WriteLine("Fl oz ");
                        break;
                    case 11:
                        Console.WriteLine("Ounce");
                        break;
                    case 12:
                        Console.WriteLine("Gal");
                        break;
                    case 13:
                        Console.WriteLine("Pound");
                        break;
                    case 14:
                        Console.WriteLine("Slices");
                        break;
                    case 15:
                        Console.WriteLine("Diced");
                        break;
                    case 16:
                        Console.WriteLine("Large");
                        break;  
                    case 17:
                        Console.WriteLine("Small");
                        break;
                }
                


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