using System;

class Program
{
    static void Main()
    {
        Random rng = new Random(4000);
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("=== CSCI 1250 Lab 06 ===");
            Console.WriteLine("1. The Grade Checker");
            Console.WriteLine("2. The Dice Table");
            Console.WriteLine("3. The Score Report");
            Console.WriteLine("4. All three");
            Console.WriteLine("5. Quit");
            Console.Write("Choose 1 through 5: ");

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Choose a number from 1 to 5.");
                Console.Write("Choose 1 through 5: ");
            }

            Console.WriteLine();

            // Exercise 1: The Grade Checker
            if (choice == 1 || choice == 4)
            {
                Console.WriteLine("=== Exercise 1: The Grade Checker ===");
                
                int score = -1;
                while (true)
                {
                    Console.Write("Score: ");
                    if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
                    {
                        break;
                    }
                    Console.WriteLine("A score must be between 0 and 100.");
                }

                if (score >= 90)
                {
                    Console.WriteLine($"{score} earns an A.");
                }
                else if (score >= 80)
                {
                    Console.WriteLine($"{score} earns a B.");
                }
                else if (score >= 70)
                {
                    Console.WriteLine($"{score} earns a C.");
                }
                else if (score >= 60)
                {
                    Console.WriteLine($"{score} earns a D.");
                }
                else
                {
                    Console.WriteLine($"{score} earns an F.");
                }
            }

          
        }

        Console.WriteLine("Goodbye.");
    }
}
