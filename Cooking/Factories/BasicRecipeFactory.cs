using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Cooking.Recipes;
using MasalaCookingApp.Enums;

namespace MasalaCookingApp.Cooking.Factories
{
    public class BasicRecipeFactory : IRecipeFactory
    {
        public IRecipe GetRecipe(Country country)
        {
            return country switch
            {
                Country.India => new IndiaRecipe(),
                Country.Ukraine => new UkraineRecipe(),
                Country.England => new EnglandRecipe(),
                _ => throw new NotImplementedException("No recipe for this country.")
            };
        }
    }
}
