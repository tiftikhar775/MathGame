namespace MathGame
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

                Console.Write("Enter here: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AdditionMode(difficulty);
                        continue;

                    case 2:
                        SubtractionMode(difficulty);
                        continue;

                    case 3:
                        MultiplicationMode(difficulty);
                        continue;

                    case 4:
                        DivisionMode(difficulty);
                        continue;  

                    case 5: 
                        difficulty = DifficultySelect(); // reassign difficulty value
                        continue;

                    case 6:
                        Console.WriteLine("Goodbye...");
                        break;

                    default:
                        Console.WriteLine("Please enter a valid option");
                        continue;
                }
                break;

/*
                if (option == 1)
                {
                    AdditionMode(difficulty);
                }
                else if (option == 2)
                {
                    SubtractionMode();
                }
                else if (option == 3)
                {
                    MultiplicationMode();
                }
                else if (option == 4)
                {
                    DivisionMode();
                } 
                else if (option == 5) 
                { 
                    continue;
                }
                else if (option == 6)
                {
                    break;
                }*/
            }

           
        }

        static int DifficultySelect() {
            Console.WriteLine("Choose Difficulty:\n");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            int difficulty;
            do
            {
                Console.Write("Enter here: ");
                difficulty = Convert.ToInt32(Console.ReadLine());
            } while (difficulty < 0 || difficulty > 3);

            return difficulty;
        }

        static void AdditionMode(int difficulty)
        {
            int attempts = 3;
            int score = 0;

            // game loop
            while (attempts > 0) {
                Random randomAdd = new Random(); // random class new instance
                int num1, num2, total, answer; 

                // change number range depending on difficulty
                // easy difficulty
                if (difficulty == 1)
                {
                    num1 = randomAdd.Next(99);
                    num2 = randomAdd.Next(99);
                    total = num1 + num2;

                    Console.WriteLine($"{num1} + {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }

                }
                // medium difficulty
                if (difficulty == 2)
                {
                    num1 = randomAdd.Next(999);
                    num2 = randomAdd.Next(999);
                    total = num1 + num2;

                    Console.WriteLine($"{num1} + {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }
                }
                // hard difficulty
                if (difficulty == 3)
                {
                    num1 = randomAdd.Next(9999);
                    num2 = randomAdd.Next(9999);
                    total = num1 + num2;

                    Console.WriteLine($"{num1} + {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }
                }

                
            }

            Console.WriteLine($"Game over. Your score was {score} points");

        }

        static void SubtractionMode(int difficulty)
        {
            int attempts = 3;
            int score = 0;

            // game loop
            while (attempts > 0)
            {
                Random randomAdd = new Random(); // random class new instance
                int num1, num2, total, answer;

                // change number range depending on difficulty
                // easy difficulty
                if (difficulty == 1)
                {
                    num1 = randomAdd.Next(99);
                    num2 = randomAdd.Next(99);
                    total = num1 - num2;

                    Console.WriteLine($"{num1} - {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }

                }
                // medium difficulty
                if (difficulty == 2)
                {
                    num1 = randomAdd.Next(999);
                    num2 = randomAdd.Next(999);
                    total = num1 - num2;

                    Console.WriteLine($"{num1} - {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }
                }
                // hard difficulty
                if (difficulty == 3)
                {
                    num1 = randomAdd.Next(9999);
                    num2 = randomAdd.Next(9999);
                    total = num1 - num2;

                    Console.WriteLine($"{num1} - {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }
                }


            }

            Console.WriteLine($"Game over. Your score was {score} points");
        }

        static void MultiplicationMode(int difficulty)
        {
            int attempts = 3;
            int score = 0;

            // game loop
            while (attempts > 0)
            {
                Random randomAdd = new Random(); // random class new instance
                int num1, num2, total, answer;

                // change number range depending on difficulty
                // easy difficulty
                if (difficulty == 1)
                {
                    num1 = randomAdd.Next(99);
                    num2 = randomAdd.Next(99);
                    total = num1 * num2;

                    Console.WriteLine($"{num1} x {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }

                }
                // medium difficulty
                if (difficulty == 2)
                {
                    num1 = randomAdd.Next(999);
                    num2 = randomAdd.Next(999);
                    total = num1 * num2;

                    Console.WriteLine($"{num1} x {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }
                }
                // hard difficulty
                if (difficulty == 3)
                {
                    num1 = randomAdd.Next(9999);
                    num2 = randomAdd.Next(9999);
                    total = num1 * num2;

                    Console.WriteLine($"{num1} x {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }
                }


            }

            Console.WriteLine($"Game over. Your score was {score} points");
        }

        static void DivisionMode(int difficulty)
        {
            int attempts = 3;
            int score = 0;

            // game loop
            while (attempts > 0)
            {
                Random randomAdd = new Random(); // random class new instance
                int num1, num2, total, answer;

                // change number range depending on difficulty
                // easy difficulty
                if (difficulty == 1)
                {
                    num1 = randomAdd.Next(99);
                    num2 = randomAdd.Next(99);
                    total = num1 / num2;

                    Console.WriteLine($"{num1} / {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }

                }
                // medium difficulty
                if (difficulty == 2)
                {
                    num1 = randomAdd.Next(999);
                    num2 = randomAdd.Next(999);
                    total = num1 + num2;

                    Console.WriteLine($"{num1} / {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }
                }
                // hard difficulty
                if (difficulty == 3)
                {
                    num1 = randomAdd.Next(9999);
                    num2 = randomAdd.Next(9999);
                    total = num1 / num2;

                    Console.WriteLine($"{num1} / {num2} = ??");

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == total)
                    {
                        Console.WriteLine("Correct!!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"Wrong. Correct Answer is: {total}");
                        attempts--;
                        if (score > 0) // prevents negative score
                        {
                            score--;
                        }
                    }
                }


            }

            Console.WriteLine($"Game over. Your score was {score} points");

        }
    }
}
