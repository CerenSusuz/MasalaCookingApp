using MasalaCookingApp.Cooking.Interfaces;
using MasalaCookingApp.Enums;

namespace MasalaCookingApp.Cooking
{
    public class MockCooker : ICooker
    {
        public void FryRice(int amount, Level level) =>
            Console.WriteLine($"Frying {amount}g rice with {level} heat");

        public void FryChicken(int amount, Level level) =>
            Console.WriteLine($"Frying {amount}g chicken with {level} heat");

        public void SaltRice(Level level) =>
            Console.WriteLine($"Salting rice with {level} intensity");

        public void SaltChicken(Level level) =>
            Console.WriteLine($"Salting chicken with {level} intensity");

        public void PepperRice(Level level) =>
            Console.WriteLine($"Peppering rice with {level} intensity");

        public void PepperChicken(Level level) =>
            Console.WriteLine($"Peppering chicken with {level} intensity");
    }
}
