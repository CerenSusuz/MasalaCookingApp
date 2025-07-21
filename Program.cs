using MasalaCookingApp.Cooking;
using MasalaCookingApp.Enums;

class Program
{
    static void Main(string[] args)
    {
        var restaurant = new Restaurant();
        var cooker = new MockCooker();

        var summer = new DateTime(2024, 7, 15);
        var winter = new DateTime(2024, 12, 15);

        Console.WriteLine("🍛 India Summer Masala:");
        restaurant.CookMasala(cooker, Country.India, summer);

        Console.WriteLine("\nUkraine Winter Masala:");
        restaurant.CookMasala(cooker, Country.Ukraine, winter);

        Console.WriteLine("\nEngland Summer Masala:");
        restaurant.CookMasala(cooker, Country.England, summer);
    }
}
