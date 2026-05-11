using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [];
        List<int> positiveNumbers = [];
        int number = -3;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine()!;
            number = int.Parse(userNumber);
            numbers.Add(number);
        }
        int sum = 0;
        int largestNumber = int.MinValue;
        foreach(var num in numbers)
        {
            sum += num;
            if(num > largestNumber)
            {
                largestNumber = num;
            }
            if(num > 0)
            {
                positiveNumbers.Add(num);
            }
        }
        double av = sum / numbers.Count;
        double average = numbers.Average();
        int smallestPositiveNumber = positiveNumbers.Min();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach(var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}