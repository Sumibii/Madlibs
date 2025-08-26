string name;
Console.WriteLine("Whats your name?");
name = Console.ReadLine();

string day;
Console.WriteLine("Name a day of the week");
day = Console.ReadLine();

string protein;
Console.WriteLine("Whats your favorite type of meat?");
protein = Console.ReadLine();

string veggie;
Console.WriteLine("Whats your favorite vegetable?");
veggie = Console.ReadLine();

string number;
Console.WriteLine("Pick a number between 1-10");
number = Console.ReadLine();

Console.WriteLine($"{name} is going to make {number} {protein} and {veggie} soup on {day}, How fun!");
Console.ReadLine();