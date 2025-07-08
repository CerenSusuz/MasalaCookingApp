using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;

namespace MasalaCookingApp.Cooking.Factories
{
    public interface IRecipeFactory
    {
        IRecipe GetRecipe(Country country);
    }
}
