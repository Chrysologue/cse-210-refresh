using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine()!;
        if (int.TryParse(userGrade, out int grade))
        {
            char letterGrade;
            if (grade >= 90)
            {
                letterGrade = 'A';
            }
            else if (grade >= 80)
            {
                letterGrade = 'B';
            }
            else if (grade >= 70)
            {
                letterGrade = 'C';
            }
            else if (grade >= 60)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            int lastDigit = grade % 10;
            string sign;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
            if (grade >= 90 || letterGrade == 'F')
            {
                sign = "";
            }

            Console.WriteLine($"Your letter grade is {letterGrade}{sign}");
            if (grade >= 70)
            {
                Console.WriteLine("Congratulations, you passed.");
            }
            else
            {
                Console.WriteLine("Sorry, you failed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid grade");
        }
    }
}