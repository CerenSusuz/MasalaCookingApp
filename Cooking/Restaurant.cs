using MasalaCookingApp.Cooking.Factories;
using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;

namespace MasalaCookingApp.Cooking
{
    public class Restaurant
    {
        public void CookMasala(ICooker cooker, Country country, DateTime currentTime)
        {
            IRecipeFactory factory;

            if (IsSummer(currentTime))
                factory = new SummerRecipeFactory();
            else
                factory = new BasicRecipeFactory();

            var recipe = factory.GetRecipe(country);
            recipe.Cook(cooker);
        }

        private bool IsSummer(DateTime date) => date.Month is >= 6 and <= 8;
    }
}
