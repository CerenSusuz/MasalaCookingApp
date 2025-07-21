using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;

namespace MasalaCookingApp.Cooking.Recipes
{
    public class UkraineRecipe : IRecipe
    {
        public void Cook(ICooker cooker)
        {
            cooker.FryRice(500, Level.Strong);
            cooker.FryChicken(300, Level.Medium);
            cooker.SaltRice(Level.Strong);
            cooker.PepperRice(Level.Low);
            cooker.SaltChicken(Level.Medium);
            cooker.PepperChicken(Level.Low);
        }
    }
}
