﻿namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            int difficulty = DifficultySelect();
            // menu loop
            while (true)
            {
                //Console.WriteLine(difficulty);
                Console.WriteLine("Choose Mode:\n");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Change Difficulty");
                Console.WriteLine("6. Quit\n");

                Console.Write("Select Mode: ");
                int mode = Convert.ToInt32(Console.ReadLine());

                if (mode == 5)
                {
                    difficulty = DifficultySelect();
                    continue;
                }

                // quit game
                if (mode == 6)
                {
                    break;
                }

                MathModeSelect(difficulty, mode);

            }
        }

        static int DifficultySelect()
        {
            Console.WriteLine("Choose Difficulty:\n");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            int difficulty;
            do
            {
                Console.Write("Enter here: ");
                difficulty = Convert.ToInt32(Console.ReadLine());
            } while (difficulty < 1 || difficulty > 3);

            return difficulty;
        }

        static int GenerateRandomNumber(int difficulty)
        {
            int number = 0;

            Random random = new Random();
            
            if (difficulty == 1)
            {
                number = random.Next(0, 50);
            } 
            else if (difficulty == 2)
            {
                number = random.Next(0, 99);
            } 
            else if(difficulty == 3)
            {
                number = random.Next(0, 999);
            }

            return number;

        }
        
        static void MathModeSelect(int difficulty, int mode)
        {
            int attempts = 3;
            int score = 0;
            int num1, num2, answer, correctAnswer;

            while (attempts > 0)
            {
                if (mode == 1)
                {
                    num1 = GenerateRandomNumber(difficulty);
                    num2 = GenerateRandomNumber(difficulty);
                    correctAnswer = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} == ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    } 
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {correctAnswer}");
                        attempts--;
                    }


                }

                if (mode == 2)
                {
                    num1 = GenerateRandomNumber(difficulty);
                    num2 = GenerateRandomNumber(difficulty);
                    correctAnswer = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} == ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {correctAnswer}");
                        attempts--;
                    }


                }

                if (mode == 3)
                {
                    num1 = GenerateRandomNumber(difficulty);
                    num2 = GenerateRandomNumber(difficulty);
                    correctAnswer = num1 * num2;
                    Console.WriteLine($"{num1} x {num2} == ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {correctAnswer}");
                        attempts--;
                    }


                }

                if (mode == 4)
                {
                    num1 = GenerateRandomNumber(difficulty);
                    num2 = GenerateRandomNumber(difficulty);
                    correctAnswer = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} == ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {correctAnswer}");
                        attempts--;
                    }
                }
            }

        }
       
    }
}
