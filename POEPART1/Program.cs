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
       public static int[] recipeUnitsofMeasure;
       public static  String [] description = new String[recipeSteps];

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of ingredients you would like to enter");
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

                recipeUnitsofMeasure = new int[noOfIngredients];
                Console.WriteLine("Select from the list below to add the measuring units the ingreadient needs");
                recipeUnitsofMeasure[i] = Convert.ToInt32(Console.ReadLine());

                switch (recipeUnitsofMeasure[i])
                //switch output will be based on users choice of measurement 
                {
                    case 1:
                        Console.WriteLine(quantity[i] + "tsp");
                        break;
                    case 2:
                        Console.WriteLine(quantity[i] + "Tbsp");
                        break;
                    case 3:
                        Console.WriteLine(quantity[i] + "Gram");
                        break;
                    case 4:
                        Console.WriteLine(quantity[i] + "Kilogram ");
                        break;
                    case 5:
                        Console.WriteLine(quantity[i] + "Cup");
                        break;
                    case 6:
                        Console.WriteLine(quantity[i] + "Millilitre ");
                        break;
                    case 7:
                        Console.WriteLine(quantity[i] + "Litre");
                        break;
                    case 8:
                        Console.WriteLine(quantity[i] + "Quart");
                        break;
                    case 9:
                        Console.WriteLine(quantity[i] + "Pint");
                        break;
                    case 10:
                        Console.WriteLine(quantity[i] + "Fl oz ");
                        break;
                    case 11:
                        Console.WriteLine(quantity[i] + "Ounce");
                        break;
                    case 12:
                        Console.WriteLine(quantity[i] + "Gal");
                        break;
                    case 13:
                        Console.WriteLine(quantity[i] + "Pound");
                        break;
                    case 14:
                        Console.WriteLine(quantity[i] + "Slices");
                        break;
                    case 15:
                        Console.WriteLine(quantity[i] + "Diced");
                        break;
                    case 16:
                        Console.WriteLine(quantity[i] + "Large");
                        break;
                    case 17:
                        Console.WriteLine(quantity[i] + "Small");
                        break;

                        Steps();
                        Display();

                }
            }
        }

        public static void Steps()
        {
            Console.WriteLine("Enter the number of steps you would like to add");
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
                for(int i = 0; i < noOfIngredients; i++)
                {
                    Console.WriteLine(ingredientName[i] + " " + quantity[i] + " " + recipeUnitsofMeasure[i]);
                }

                for (int b = 0; b < recipeSteps; b++)
                {
                    Console.WriteLine("Step {0}", b + 1);
                    Console.WriteLine(description[b]);
                }
            }
            else if (option == 2)
            {


            }


            Console.ReadKey();
        }

        public static void Adjust()
        {

        }
            

        
    } 
    
}