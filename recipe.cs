using System;
using System.Collections.Generic;
namespace recipeApp_Part_2
{
	public class recipe
	{
		public string Name { get; set; } // Represents name of the property
        public List<ingredient> Ingredients { get; set; } //Represents the collection of ingredients. 
		public List<string> Steps { get; set; }// Represents collection of steps in making recipe


		public recipe(string name)
		{
			this.Name = name;
			Ingredients = new List<ingredient>();
			this.Steps = new List<string>();
		}

        
        
    }
		
}

