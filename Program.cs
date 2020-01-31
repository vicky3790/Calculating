using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;
                try
                {
                    Console.WriteLine("Choose your first number");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Choose the second one");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("No No No! Be attentive! Try again.");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("What do you want to do with them? '+', '-', '*', '/'");
                action = Console.ReadLine();
                
                switch (action)
                {
                    case "+":
                        Console.WriteLine("=" + (firstValue + secondValue));
                        break;
                    case "-":
                        Console.WriteLine("=" + (firstValue - secondValue));
                        break;
                    case "*":
                        Console.WriteLine("=" + (firstValue * secondValue));
                        break;
                    case "/":
                        Console.WriteLine("=" + (firstValue / secondValue));
                        if (secondValue == 0)
                            Console.WriteLine("Have you ever heard about the rules of division?!");
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;
                    default:
                        Console.WriteLine("Error. Try again");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
  