using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;
using MasalaCookingApp.SummerRecipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasalaCookingApp.Cooking.Factories
{
    public class SummerRecipeFactory : IRecipeFactory
    {
        public IRecipe GetRecipe(Country country)
        {
            return country switch
            {
                Country.India => new IndiaSummerRecipe(),
                Country.Ukraine => new UkraineSummerRecipe(),
                Country.England => new EnglandSummerRecipe(),
                _ => throw new NotImplementedException("No summer recipe for this country.")
            };
        }
    }
}
