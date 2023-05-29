using System;
using System.Collections.Generic;
namespace recipeApp_Part_2
{
	public class recipeBook
	{
        //Creating a Recipe Collection that hold objects
        ///from recipe class
		private List<recipe> Recipes;
        //public delegate void CaloriesEvent(string recipeName, in totalCalories);

        public recipeBook()
        {
            Recipes = new List<recipe>();
        }
        double factor = 0.0;

        public void displayRecipe(string RecipeName)
        {
            //Searching for recipe in the recipe list collection by name
            //FirstOrDefault method return the first element in recipe list that
            //meets conditions of searchedRecipeName 
            recipe searchedRecipe = Recipes.FirstOrDefault(r => r.Name.Equals(RecipeName));


            //statement indicates that if no recipe in the collection matches
            // searchedRecipe it will print the message, and if the searcheRecipe is null
            if(searchedRecipe == null)
            {
                Console.WriteLine("Contact not found");

            }
            //if searchedRecipe is found in the Recipe Collection
            // the display Recipe Deatails is called, which will
            // print the details of the recipe that was searched
            else
            {
                displayRecipeDetails(searchedRecipe);
            }
        }

        public void scaleIngredients()
        {

            Console.WriteLine("SCALE RECIPE");
            Console.WriteLine("----------");
            Console.WriteLine("SEARCH NAME: ");
            string searchName = Console.ReadLine();
            Console.WriteLine("----------");
            Console.WriteLine("type 'exit' to leave Scale");

            

            if (searchName.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            recipe scaleSearchedRecipe = Recipes.FirstOrDefault(r => r.Name.Equals(searchName));

            while (scaleSearchedRecipe == null)
            {
                Console.WriteLine("Recipe does not exist. Please enter a valid name.");
                searchName = Console.ReadLine();

                if (searchName.Equals("exit"))
                {
                    return;
                }

                scaleSearchedRecipe = Recipes.FirstOrDefault(r => r.Name.Equals(searchName));

            }

            Console.WriteLine("Enter the scaling factor (0.5, 2, 3)");
            factor = double.Parse(Console.ReadLine());

            foreach (ingredient Ingredient in scaleSearchedRecipe.Ingredients)
            {
                Ingredient.Quantity *= factor;
            }

            Console.WriteLine($"Recipe {scaleSearchedRecipe.Name} was scaled by {factor}");
        }

        //Code prompts user to create a new recipe
        //The user is prompted to added recipe details such as
        // Name, Ingredients and Steps
        public void createRecipe()
		{
            //Prompts user to enter a Recipe Name into name variable
			Console.WriteLine("Recipe Name: ");
			string name = Console.ReadLine();
	 Console.WriteLine("--------------");
            //Creating an instance of the recipe Class
            // naming it Recipe and intializing it with a name
			recipe Recipe = new recipe(name);

            //User is asked how many ingredeinets a recipe has
			Console.WriteLine("Enter number of ingredients: ");
            //Number of ingredients is stored in ingredient counter
            //Which will be the control of the loop 
			int ingredientCount = int.Parse(Console.ReadLine());
		 Console.WriteLine("--------------");
            //Each iteration of the loop prompts user to enter details of the ingredient
           
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter the details of ingredient #{i + 1}:");
                //A new instance of the ingredient class is created,c alled Ingredient
                //Which will help intialize default values of ingredient class
                ingredient Ingredient = new ingredient();

                Console.Write("Name: ");
                Ingredient.Name = Console.ReadLine();
		Console.WriteLine("----");
                
		Console.Write("Quantity: ");
                Ingredient.Quantity = double.Parse(Console.ReadLine());
		Console.WriteLine("----");
                
		Console.Write("Unit of Measurement: ");
                Ingredient.UnitOfMeasurement = Console.ReadLine();
		 Console.WriteLine("----");
                Console.Write("Calories: ");
                Ingredient.Calories = int.Parse(Console.ReadLine());
		 Console.WriteLine("----");
                Console.WriteLine("Food Group (pick a number): ");
                Console.WriteLine("1. Grains\n" +
                    "2. Vegetable\n" +
                    "3. Meat/Poultry/Fish/Eggs\n" +
                    "4. Fruit\n" +
                    "5. Sweets");
                var fgSelect = Console.ReadLine(); ;

                switch (fgSelect)
                {
                    case "1":
                        Ingredient.FoodGroup = "Grains";
                        break;
                    case "2":
                        Ingredient.FoodGroup = "Vegetables";
                        break;
                    case "3":
                        Ingredient.FoodGroup = "Meat/Poultry/Fish/Eggs";
                        break;
                    case "4":
                        Ingredient.FoodGroup = "Fruit";
                        break;
                    case "5":
                        Ingredient.FoodGroup = "Sweets";
                        break;
                }

                

                Recipe.Ingredients.Add(Ingredient);
            }
		Console.WriteLine("----");
            Console.WriteLine("Enter the steps to make the recipe (enter 'x' to finish):");

            string step = Console.ReadLine();
            while (step != "x")
            {
                Recipe.Steps.Add(step);
                step = Console.ReadLine();
            }

            //Adding recipe to Recipes Collection
            Recipes.Add(Recipe);

            Console.WriteLine("Recipe created successfully!");


        }

        
        public void displayAllRecipes()
        {
            //Creates new list which will store Recipe names in Alphabetical
            // order by using OrderBy method which sorts recipes in ascending order by name.
            List<recipe> alphabeticalList = Recipes.OrderBy(r => r.Name).ToList();
            Console.WriteLine("Recipes:");

            //Code iterates through recipe objects in the Alphabetical List
            //using foreach loop.
            foreach (recipe Recipe in alphabeticalList)
            {
                Console.WriteLine(Recipe.Name);
            }
        }

        //This medthod takes the Recipe object as a parameter
        //It will print the contents of a specified recipe when given the name
        private void displayRecipeDetails(recipe Recipe)//Recipe chosen because it is singular
        {
            //Displays the name of the recipe by accessing Name property
            //of the Recipe object/class
            Console.WriteLine($"Recipe: {Recipe.Name}");
            Console.WriteLine("Ingredients:");

            //Loop through Ingredients collection insid the Recipe class/object
            foreach (ingredient Ingredient in Recipe.Ingredients)
            {
                Console.WriteLine($"{Ingredient.Name} - {Ingredient.Quantity} {Ingredient.UnitOfMeasurement}\n" +
                    $"Calories: {Ingredient.Calories}\n" +
                    $"Food Group: {Ingredient.FoodGroup}");
            }
            Console.WriteLine("Steps:");
            //Code loops through the Steps Collection in the Recipe Objcet and displays
            //each element
            for (int i = 0; i < Recipe.Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Recipe.Steps[i]}");
            }
        }

        //Method clears the Recipes Collection
        // After invocation Recipe Collection will be empty.
		public void clearRecipeList()//Chosen name because function clears all recipes in the Recipes List/Collection
        {
            Recipes.Clear();
        }


        //Method prompts user to enter a recipe name, serches for matching recipe
        //inside recipe collection, once found it will divide
        //quantities by factor
        public void revertScale()
        {
            Console.WriteLine("Revert Scale");
            Console.WriteLine("------");
            Console.WriteLine("SEARCH BY NAME");
            string searchedName = Console.ReadLine();
            Console.WriteLine("------");

            //USes Find method to find recipe specified in searchedName
            recipe revertRecipe = Recipes.Find(r => r.Name == searchedName);

            if (revertRecipe != null)
            {
                foreach(ingredient Ingredient in revertRecipe.Ingredients)
                {
                    Ingredient.Quantity /= factor;
                }
            }
            else
            {
                Console.WriteLine("Recipe not found");
            }
        }
	}
}

