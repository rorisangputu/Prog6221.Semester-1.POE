using System;
namespace recipeApp_Part_2
{
	public class ingredient
	{
        public delegate void countCalories(int total);
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }
    }
}

