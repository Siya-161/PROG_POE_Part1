using System;

namespace Part1
{
    public class RecipeApp
    {
        int noOfIngredients;
        string[] ingredientNames;
        double[] quantities;
        string[] unitsOfMeasurement;
        int noOfSteps;
        string[] stepsDescription;
        double factor;
         
        public static void Main(string[] args)
        {
            RecipeApp app = new RecipeApp();

            app.factor = 1.0;

            enterRecipe(app);

            enterSteps(app);

            display(app);

            menu(app);


        }

        public static void enterRecipe(RecipeApp app) // method for entering the details of a recipe
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome. Please proceed to enter the details for your recipe.");
            underline();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Number of ingredients: ");
            Console.ResetColor();
            app.noOfIngredients = Convert.ToInt32(Console.ReadLine());
            app.ingredientNames = new string[app.noOfIngredients];
            app.quantities = new double[app.noOfIngredients];
            app.unitsOfMeasurement = new string[app.noOfIngredients];
            int inputStorage;
            underline();
            

            for (int i = 0; i < app.noOfIngredients; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Name of ingredient #{0}: ", i + 1);
                app.ingredientNames[i] = Console.ReadLine();

                Console.WriteLine("Quantity of ingredient #{0}: ", i + 1);
                inputStorage = Convert.ToInt32(Console.ReadLine());
                app.quantities[i] = Convert.ToDouble(inputStorage);

                Console.WriteLine("Unit of measurement for ingredient #{0}: ", i + 1);
                app.unitsOfMeasurement[i] = Console.ReadLine();
                Console.ResetColor();
                underline();
            }
        }

        public static void enterSteps(RecipeApp app) //method for entering the number of steps and step descriptions
        {
            Console.WriteLine("Enter the number of steps: ");
            app.noOfSteps = Convert.ToInt32(Console.ReadLine());
             
            app.stepsDescription = new string[app.noOfSteps];
            underline();

            for (int i2 = 0; i2 < app.noOfSteps; i2++)
            {
                Console.WriteLine("For step #{0} enter a description of what the user should do: ", i2 + 1);
                app.stepsDescription[i2] = Console.ReadLine();
                underline();
            }
        }

        public static void underline() //method to add an underline either before or after bodies of text, for added neatness
        {
            Console.WriteLine("----------------------------------------------------");
        }

        public static void display(RecipeApp app) //method for displaying the full recipe to the user
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Recipe details: ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Ingredients: ");

            Console.ResetColor();

            for (int i=0; i < app.noOfIngredients; i++ )
            {
                Console.WriteLine(app.quantities[i] + app.unitsOfMeasurement[i] + " of " + app.ingredientNames[i] );
                 

            }
            underline();
            Console.WriteLine("Steps: ");
            for (int i = 0; i < app.noOfSteps; i++)
            {
                Console.WriteLine("Step #{0} " + app.stepsDescription[i], i+1);


            }

            underline();
        }

        public static void menu(RecipeApp app) // this is a menu that users can pick options on how to manipulate the recipe from. 
        {
            int menuOption;

            underline();
            int sentinelValue = 1;
        
        while(sentinelValue == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("1. Scale Recipe \r\n" +
                "2. Reset values \r\n" +
                "3. Clear data and enter new recipe \r\n"
                + "4. Display \r\n"
                + "5. Close app");
                Console.ResetColor();

                menuOption = Convert.ToInt32(Console.ReadLine());


                if (menuOption == 1)
                {
                    sentinelValue = 0;
                    scaleValues(app);
                    
                }

                else if (menuOption == 2)
                {
                    sentinelValue = 0;
                    resetValues(app);
                    
                }

                else if (menuOption == 3)
                {
                    sentinelValue = 0;
                    clearAndEnterNew(app);
                    
                }

                else if(menuOption == 4)
                {
                    display(app);
                }

                else if(menuOption == 5)
                {
                    Environment.Exit(0);
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid value");
                    sentinelValue = 1;
                    Console.ResetColor();
                }
            }
            
        }
        public static void scaleValues(RecipeApp app) //this method scales the values of the recpie ingredients
        {
             

            Console.WriteLine("Enter the factor you would like to scale the recipe by: ");
            app.factor = Convert.ToDouble(Console.ReadLine());



            for (int i = 0; i < app.noOfIngredients; i++)
            {
                app.quantities[i] = app.quantities[i] * app.factor;
            }

            Console.WriteLine("The recipe has been scaled");

            menu(app);
        }

        public static void resetValues(RecipeApp app) //this method resets the scale of the recipe
        {
            for (int i = 0; i < app.noOfIngredients; i++)
            {
                app.quantities[i] = app.quantities[i] / app.factor;
            }

            Console.WriteLine("The recipe has been reset");


            menu(app);
        }

        public static void clearAndEnterNew(RecipeApp app) //this method clears the entire recipe and allows the user to enter new ingredients and steps
        {
            app.noOfIngredients = 0;
            app.noOfSteps = 0;
            app.factor = 0.0;
            Array.Clear(app.ingredientNames, 0, app.ingredientNames.Length);
            Array.Clear(app.quantities, 0, app.quantities.Length);
            Array.Clear(app.unitsOfMeasurement, 0, app.unitsOfMeasurement.Length);
            Array.Clear(app.stepsDescription, 0, app.stepsDescription.Length);

            enterRecipe(app);
            enterSteps(app);
            display(app);
            menu(app);
        }
    }
}
