using MasalaCookingApp.Cooking.Factories;
using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;

namespace MasalaCookingApp.Cooking
{
    public class Restaurant
    {
        public void CookMasala(ICooker cooker, Country country)
        {
            IRecipeFactory factory = new BasicRecipeFactory();
            var recipe = factory.GetRecipe(country);
            recipe.Cook(cooker);
        }
    }
}
