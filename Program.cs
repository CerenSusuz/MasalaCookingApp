using MasalaCookingApp.Cooking;
using MasalaCookingApp.Enums;

class Program
{
    static void Main(string[] args)
    {
        var restaurant = new Restaurant();
        var cooker = new MockCooker();

        Console.WriteLine("India Masala:");
        restaurant.CookMasala(cooker, Country.India);

        Console.WriteLine("\nUkraine Masala:");
        restaurant.CookMasala(cooker, Country.Ukraine);

        Console.WriteLine("\nEngland Masala:");
        restaurant.CookMasala(cooker, Country.England);
    }
}
