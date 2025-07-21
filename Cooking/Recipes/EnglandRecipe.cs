using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;

namespace MasalaCookingApp.Cooking.Recipes
{
    public class EnglandRecipe : IRecipe
    {
        public void Cook(ICooker cooker)
        {
            cooker.FryRice(100, Level.Low);
            cooker.FryChicken(100, Level.Low);
            // No salt or pepper
        }
    }
}
