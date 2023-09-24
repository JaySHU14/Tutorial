// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string user = "Anabella";
Console.WriteLine("Hello" + user + "!");
Console.WriteLine($"Hello, {user}!");

Console.WriteLine("What is your name?");
string user1 = Console.ReadLine();
Console.WriteLine($"Hello, {user}!");

string defaultName = "Anonymous";
Console.WriteLine("What is your name?");
string user2 = Console.ReadLine();
user2 = user2.Trim().Length == 0 ? defaultName : user2;
Console.WriteLine($"Hello, {user}!");

