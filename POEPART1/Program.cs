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

                Console.WriteLine("Select from the list below to add the measuring units");
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
                recipeUnitsofMeasure = Convert.ToInt32(Console.ReadLine());

                switch(recipeUnitsofMeasure)
                    //switch output will be based on users choice of measurement 
                {
                    case 1:
                        Console.WriteLine("1. tsp");
                        break;
                    case 2:
                        Console.WriteLine("2.Tbsp");
                        break;
                    case 3:
                        Console.WriteLine("3. Gram");
                        break;
                    case 4:
                        Console.WriteLine("4.  Kilogram ");
                        break;
                    case 5:
                        Console.WriteLine("5. Cup");
                        break;
                    case 6:
                        Console.WriteLine("6. Millilitre ");
                        break;
                    case 7:
                        Console.WriteLine("7. Litre");
                        break;
                    case 8:
                        Console.WriteLine("8. Quart");
                        break;
                    case 9:
                        Console.WriteLine("9. Pint");
                        break;
                    case 10:
                        Console.WriteLine("10. Fl oz ");
                        break;
                    case 11:
                        Console.WriteLine("11. Ounce");
                        break;
                    case 12:
                        Console.WriteLine("12, Gal");
                        break;
                    case 13:
                        Console.WriteLine("13. Pound");
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