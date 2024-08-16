using System;

namespace Week6Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minValue = 1;
            int maxValue = 100;
            int maxAttempts = 3;
            Random random = new Random();
            int randomNumber = random.Next(minValue, maxValue + 1);

            Console.WriteLine($"Guess the number between {minValue} and {maxValue}. You have {maxAttempts} attempts.");
            int attempts = 0;
            bool Guess = false;

            while (attempts < maxAttempts && !Guess)
            {
                Console.Write("Enter your guess: ");
                try
                {
                    int userGuess = int.Parse(Console.ReadLine());
                    attempts++;

                    bool Range = false;

                    for (int i = minValue; i <= maxValue; i++)
                    {
                        if (userGuess == i)
                        {
                            Range = true;
                            break;
                        }
                    }

                    if (Range)
                    {
                        if (userGuess < randomNumber)
                        {
                            Console.WriteLine("Too low!");
                        }
                        else if (userGuess > randomNumber)
                        {
                            Console.WriteLine("Too high!");
                        }
                        else
                        {
                            Guess = true;
                            Console.WriteLine($"Congratulations!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your guess is out of range!");
                    }

                    if (attempts == maxAttempts && !Guess)
                    {
                        Console.WriteLine($"Sorry, The correct number was {randomNumber}.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



                Console.WriteLine("Game Over.");
            }
        }
    }
}

