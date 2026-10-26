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
// Exercise 2: The Dice Table
            if (choice == 2 || choice == 4)
            {
                Console.WriteLine("=== Exercise 2: The Dice Table ===");

                int rolls = 0;
                int wins = 0;
                string again = "y";

                while (again == "y" || again == "Y")
                {
                    rolls++;
                    int d1 = rng.Next(1, 7);
                    int d2 = rng.Next(1, 7);
                    int total = d1 + d2;

                    Console.Write($"Roll {rolls}: {d1} and {d2}, total {total}. ");

                    if (d1 == 1 && d2 == 1)
                    {
                        Console.WriteLine("Snake eyes.");
                    }
                    else if (d1 == d2)
                    {
                        Console.WriteLine("Doubles!");
                    }
                    else if (total == 7 || total == 11)
                    {
                        Console.WriteLine("A winner.");
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                    if (total == 7 || total == 11)
                    {
                        wins++;
                    }

                    Console.Write("Roll again? (y/n): ");
                    again = Console.ReadLine();
                }

                Console.WriteLine($"You rolled {rolls} times and won {wins}.");
            }
// Exercise 3: The Score Report
            if (choice == 3 || choice == 4)
            {
                Console.WriteLine("=== Exercise 3: The Score Report ===");

                int[] scores = new int[5];

                for (int i = 0; i < scores.Length; i++)
                {
                    Console.Write($"Score {i + 1}: ");
                    scores[i] = int.Parse(Console.ReadLine());
                }

                int total = 0;
                int high = scores[0];
                int passing = 0;

                foreach (int s in scores)
                {
                    total += s;

                    if (s > high)
                    {
                        high = s;
                    }

                    if (s >= 60)
                    {
                        passing++;
                    }
                }

                double avg = (double)total / scores.Length;

                Console.WriteLine($"Scores entered: {scores.Length}");
                Console.WriteLine($"Total: {total}");
                Console.WriteLine($"Average: {avg:F1}");
                Console.WriteLine($"Highest: {high}");
                Console.WriteLine($"Passing: {passing} of {scores.Length}");
            }
        }

        Console.WriteLine("Goodbye.");
    }
}
