using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasalaCookingApp.SummerRecipes
{
    public class IndiaSummerRecipe : IRecipe
    {
        public void Cook(ICooker cooker)
        {
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);

            // No salt for rice
            cooker.PepperRice(Level.Medium);

            // No salt for chicken
            cooker.PepperChicken(Level.Medium);
        }
    }
}
