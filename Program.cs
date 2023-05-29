using System.Collections.Generic;
namespace recipeApp_Part_2;
class Program
{
    

    

    

    static void Main(string[] args)
    {
        recipeBook RecipeBook = new recipeBook();
        var input = "";
        do
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("REICPE APP");
            Console.WriteLine("----------------------");
            Console.WriteLine("Select Option");
            Console.WriteLine("----");
            Console.WriteLine("1. Add New Recipe");

            Console.WriteLine("2. Display Recipes");
            //Must display recipe names & recipe by name

            Console.WriteLine("3. Scale Recipe");
            //Must be able to scale a specific recipe

            Console.WriteLine("4. Reset quantities");
            Console.WriteLine("5. Clear all data");
            Console.WriteLine("Press 'X' to exit program");
             input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RecipeBook.createRecipe();
                    break;

                case "2":
                    RecipeBook.displayAllRecipes();

                    Console.WriteLine("View a RECIPE (y or n): ");
                    string view = Console.ReadLine();
                    if (view == "y")
                    {
                        Console.WriteLine("Recipe Name");
                        string searchedRecipeName = Console.ReadLine();
                        RecipeBook.displayRecipe(searchedRecipeName);

                    }
                    break;

                case "3":
                    RecipeBook.scaleIngredients();
                    break;

                case "4":
                    RecipeBook.revertScale();
                    break;

                case "5":
                    RecipeBook.clearRecipeList();
                    break;

                case "x":
                    return;
                    break;

                default:
                    Console.WriteLine("Enter a valid operation.");
                    break;
            }
        } while (input != "X");

        
    }
}

