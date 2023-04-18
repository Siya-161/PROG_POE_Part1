using System;

namespace Part1
{
    public class RecipeApp
    {
        int noOfIngredients;
        string[] ingredientNames;
        int[] quantities;
        string[] unitsOfMeasurement;
        int noOfSteps;
        string[] stepsDescription;
        //string[] ingredients;
        //string[] steps;
        public static void Main(string[] args)
        {
            RecipeApp app = new RecipeApp();

            enterRecipe(app);

            enterSteps(app);

            display(app);


        }

        public static void enterRecipe(RecipeApp app) // method for entering the details of a recipe
        {
            Console.WriteLine("Welcome. Please proceed to enter the details for your recipe.");
            underline();

            Console.WriteLine("Number of ingredients: ");
            app.noOfIngredients = Convert.ToInt32(Console.ReadLine());
            app.ingredientNames = new string[app.noOfIngredients];
            app.quantities = new int[app.noOfIngredients];
            app.unitsOfMeasurement = new string[app.noOfIngredients];
            underline();

            for (int i = 0; i < app.noOfIngredients; i++)
            {
                Console.WriteLine("Name of ingredient #{0}: ", i + 1);
                app.ingredientNames[i] = Console.ReadLine();

                Console.WriteLine("Quantity of ingredient #{0}: ", i + 1);
                app.quantities[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Unit of measurement for ingredient #{0}: ", i + 1);
                app.unitsOfMeasurement[i] = Console.ReadLine();
                underline();
            }
        }

        public static void enterSteps(RecipeApp app) //method for entering the number of steps and step descriptions
        {
            Console.WriteLine("Enter the number of steps: ");
            app.noOfSteps = Convert.ToInt32(Console.ReadLine());
            //app.steps = new string[app.noOfSteps];
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
            Console.WriteLine("Recipe details: ");

            Console.WriteLine("Ingredients: ");
            for(int i=0; i < app.noOfIngredients; i++ )
            {
                Console.WriteLine(app.quantities[i] + app.unitsOfMeasurement[i] + " of " + app.ingredientNames[i] );
                 

            }
            underline();
            Console.WriteLine("Steps: ");
            for (int i = 0; i < app.noOfSteps; i++)
            {
                Console.WriteLine("Step #{0} " + app.stepsDescription[i], i+1);


            }
        }

        public static void menu(RecipeApp app)
        {
            int menuOption;
            Console.WriteLine("1. Scale Recipe \r\n" +
                "2. Reset values \r\n" +
                "3. Clear data and enter new recipe \r\n");

            menuOption = Convert.ToInt32 (Console.ReadLine());

            
            if(menuOption == 1 )
            {
                scaleValues(app);
            }

            else if(menuOption == 2 )
            {
                resetValues(app);
            }

            else if( menuOption == 3 )
            {
                clearAndEnterNew(app);
            }

            else
            {
                Console.WriteLine("You have entered an invalid value");
            }
        }
        public static void scaleValues(RecipeApp app)
        {
            double factor;
            Console.WriteLine("Enter the factor you would like to scale the recipe by: ");
            factor = Convert.ToDouble (Console.ReadLine());

        }

        public static void resetValues(RecipeApp app)
        {
            Console.WriteLine();
        }

        public static void clearAndEnterNew(RecipeApp app)
        {
            Console.WriteLine();
        }
    }
}
