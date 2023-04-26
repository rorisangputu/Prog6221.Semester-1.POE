namespace Proji;
class Program
{
    static void Main(string[] args)
    {

        Recipe recipe = new Recipe();
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine("My Cook Book Application");
            Console.WriteLine("****************************");
            Console.WriteLine("1. Add Recipe.");
            Console.WriteLine("2. Display Recipe.");
            Console.WriteLine("3. Scale Recipe");
            Console.WriteLine("4. Reset Quantities");
            Console.WriteLine("5. Clear Recipe");
            Console.WriteLine("0. Exit program");
            Console.WriteLine();
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************");
            switch (option)
            {
                case 1:
                    recipe.RecipeDetails();
                    break;

                case 2:
                    recipe.Display();
                    break;

                case 3:
                    Console.Write("Enter Scale Factor (0.5, 2, 3): ");
                    double factor = double.Parse(Console.ReadLine());
                    recipe.Scale(factor);
                    break;

                case 4:
                    recipe.resetScale();
                    break;

                case 5:
                    recipe.ClearDetails();
                    break;

                case 0:
                    Console.WriteLine("Bye");
                    return;

                default:
                    Console.WriteLine("Invalid input. Choose numbers from menu.");
                    break;
            }
        }

       
    }
}


