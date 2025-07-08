using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasalaCookingApp.SummerRecipes
{
    public class EnglandSummerRecipe : IRecipe
    {
        public void Cook(ICooker cooker)
        {
            cooker.FryRice(50, Level.Low);
            cooker.FryChicken(50, Level.Low);
            // No salt or pepper
        }
    }
}
