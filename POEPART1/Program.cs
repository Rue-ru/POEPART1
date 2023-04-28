using System;
using System.Security.Cryptography.X509Certificates;

namespace POE_part1
{
    
    public class Program
    {
       public static int recipeSteps;
       public static int noOfIngredients;
       public static String[] ingredientName;
       public static int[] quantity;
       public static string[] recipeUnitsofMeasure;
       public static  String [] description = new String[recipeSteps];

        static void Main(string[] args)
        {
            Console.WriteLine("\n Enter the number of ingredients you would like to enter");
            noOfIngredients = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noOfIngredients; i++)
            {

                ingredientName = new string[noOfIngredients];
                Console.WriteLine("Enter the ingredients name with capital letters");
                //enter the ingredients you want 
                ingredientName[i] = Console.ReadLine();


                quantity = new int[noOfIngredients];
                Console.WriteLine();
                Console.WriteLine("Enter the ingredients quantity");
                quantity[i] = Convert.ToInt32(Console.ReadLine());

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

                recipeUnitsofMeasure = new string[noOfIngredients];
                Console.WriteLine("Looking at the list provided above, type out the quantity you want to use");
                recipeUnitsofMeasure[i] = Console.ReadLine();
            }

            int menu;
            Console.WriteLine("1 --> Menu");
            Console.WriteLine("2 --> Exit");
            menu = Convert.ToInt32(Console.ReadLine());
            while (menu <1)
            {
                Steps();
                Display();
                Adjust();
            }
            
        }

        public static void Steps()
        {
            Console.WriteLine("\n Enter the number of steps you would like to add");
            recipeSteps = Convert.ToInt32(Console.ReadLine());

            description = new String[recipeSteps];

            for (int b = 0; b < recipeSteps; b++)
            {
                Console.WriteLine("Step {0}", b + 1);
                description[b] = Console.ReadLine();
            }

        }
        public static void Display()

        {
            int option;
            Console.WriteLine("Would you like display the entire recipe or clear the entire recipe out:");
            Console.WriteLine("1 --> Display");
            Console.WriteLine("2 --> Clear recipe");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("INGREDIENTS");
                for (int i = 0; i < noOfIngredients; i++)
                {
                    Console.WriteLine(ingredientName[i] + " " + quantity[i] + " " + recipeUnitsofMeasure[i]);
                }
                
                Console.WriteLine("\n METHOD");
                for (int b = 0; b < recipeSteps; b++)
                {
               
                    Console.WriteLine("Step {0}", b);
                    Console.WriteLine(description[b]);
                }
                Console.ResetColor();
            }
            else if (option == 2)
            {
                Array.Clear(ingredientName, 0, ingredientName.Length);
                Array.Clear(quantity, 0, quantity.Length);
                Array.Clear(recipeUnitsofMeasure, 0, recipeUnitsofMeasure.Length);
                Array.Clear(description, 0, description.Length);

            }

            Console.ReadKey();
        }

        public static void Adjust()
        {
            int option2;
            Console.WriteLine("Would you like half, double or triple the recipe incredients ");
            Console.WriteLine("1 --> half");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> triple");
            Console.WriteLine("4 --> done");
            option2 = Convert.ToInt32(Console.ReadLine());

            if (option2 == 1)
            {
                for (int i = 0; i < noOfIngredients; i++)
                {
                    Console.WriteLine(ingredientName[i] + " " + quantity[i]/0.5 + " " + recipeUnitsofMeasure[i]);

                }

                for (int b = 0; b < recipeSteps; b++)
                {
                    Console.WriteLine("INGREDIENTS");
                    Console.WriteLine("Step {0}", b);
                    Console.WriteLine("\n METHOD");
                    Console.WriteLine(description[b]);
                }

            }
            else if (option2 == 2)
            {
                for (int i = 0; i < noOfIngredients; i++)
                {
                    Console.WriteLine(ingredientName[i] + " " + quantity[i] * 2  + " " + recipeUnitsofMeasure[i]);
                }

                for (int b = 0; b < recipeSteps; b++)
                {
                    Console.WriteLine("INGREDIENTS");
                    Console.WriteLine("Step {0}", b);
                    Console.WriteLine("\n METHOD");
                    Console.WriteLine(description[b]);
                }

            }

            else if (option2 == 3)
            {
                for (int i = 0; i < noOfIngredients; i++)
                {
                    Console.WriteLine(ingredientName[i] + " " + quantity[i] * 3 + " " + recipeUnitsofMeasure[i]);
                }

                for (int b = 0; b < recipeSteps; b++)
                {
                    Console.WriteLine("INGREDIENTS");
                    Console.WriteLine("Step {0}", b);
                    Console.WriteLine("\n METHOD");
                    Console.WriteLine(description[b]);
                }
            }
            else if (option2 ==4)
            {
                Console.ReadKey();
            }
        }
        
    } 
    
}