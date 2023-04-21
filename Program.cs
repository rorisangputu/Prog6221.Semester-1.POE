namespace Proji;
class Program
{
    static void Main(string[] args)
    {

        Recipe recipe = new Recipe();

        Console.WriteLine("****************************");
        Console.WriteLine("My Cook Book Application");
        Console.WriteLine("****************************");
        Console.WriteLine("1. Add Recipe.");
        Console.WriteLine("2. Display Recipe.");
        Console.WriteLine("3. Scale Recipe");
        Console.WriteLine("4. Reset Quantities");
        Console.WriteLine("5. Clear Recipe");
        Console.WriteLine("0. Exit program");

        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                recipe.RecipeDetails();
                break;
        }
    }
}
