// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Player! What is your name?");

string name = Console.ReadLine();

Console.WriteLine($"{name}, what is your gold?");

int gold = int.Parse(Console.ReadLine());

Console.WriteLine($"{name}, you are out on the town when you spot a bronze sword through the window of a shop");
Console.WriteLine("You are immediatly drawn to it and want to buy it");
Console.WriteLine("You notice the price: 15 Gold");

if (gold >= 15)
{
    gold -= 15;
    Console.WriteLine("You buy the sword using your gold. It is a bit heavy but you'll surely get used to it after awhile");
    Console.WriteLine($"You now have {gold} gold. Congratulations, you did a capitalism");
    ;
}

else
{
    Console.WriteLine($"You do not have enough gold, {name}. You need {15-gold} more gold to purchase it");
    Console.WriteLine("You walk away with your head held low... depressed");
    ;
}