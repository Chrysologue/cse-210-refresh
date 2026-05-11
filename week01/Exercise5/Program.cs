using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayName();
        Console.WriteLine(DisplayReuslt());
    }
    static void DisplayName()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine()!;
        return name;
    }
    static int PromptUserAge()
    {
        Console.Write("Please enter your age: ");
        string age = Console.ReadLine()!;
        int validAge = int.Parse(age);
        return validAge;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static string DisplayReuslt()
    {
        return$"{PromptUserName()}, the square of your number is: {SquareNumber(PromptUserAge())}";
    }
}