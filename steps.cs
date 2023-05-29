using System;
using System.Collections.Generic;
namespace recipeApp_Part_2
{
	public class steps
	{
		//Constructor of steps class
		//Creates instances of the steps class
		public steps(string description) 
		{
			Description = description; 
		}

		public string Description { get; set; }// Property represents the description of a step
    }
}

