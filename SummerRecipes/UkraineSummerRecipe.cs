using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasalaCookingApp.SummerRecipes
{
    public class UkraineSummerRecipe : IRecipe
    {
        public void Cook(ICooker cooker)
        {
            cooker.FryRice(150, Level.Medium);
            cooker.FryChicken(200, Level.Medium);

            cooker.SaltRice(Level.Low);
            // No pepper for rice

            cooker.SaltChicken(Level.Low);
            // No pepper for chicken
        }
    }
}
