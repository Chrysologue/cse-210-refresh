using System;

class Program
{
    static void Main(string[] args)
    {
        bool isPlayingAgain = true;
        
        

        while (isPlayingAgain)
        {
            var randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 100);
            int number = -5;
            int guessCount = 0;

            while (number != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine()!;
                guessCount += 1;
                number = int.Parse(guess);
                if(number == guessCount)
                {
                    break;
                }
                else if (number < magicNumber)
                {
                    Console.WriteLine("Guess higher");
                }
                else
                {
                    Console.WriteLine("Guess lower");
                }
            }
            Console.WriteLine("Congratulations! you have guessed it.");
            Console.WriteLine($"The magic number is: {magicNumber}");
            Console.WriteLine($"You have guessed it {guessCount} times");
            Console.Write("Would you like to play again? ");
            string userChoice = Console.ReadLine()!;
            if (userChoice.ToLower() == "yes")
            {
                isPlayingAgain = true;
            }
            else
            {
                isPlayingAgain = false;
            }

        }

    }
}