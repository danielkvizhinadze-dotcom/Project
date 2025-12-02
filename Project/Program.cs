using System.Diagnostics;

Console.WriteLine("Enter 1 to add a book");
Console.WriteLine("Enter 2 to see all current books");
Console.WriteLine("Enter 3 to search for a book");

var UserInput=Console.ReadKey(true).Key;
switch (UserInput)
{
    case ConsoleKey.D1:
    case ConsoleKey.F1:
        break;
    default:
        Console.WriteLine("wrong input"); break;
}