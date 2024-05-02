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
            Console.WriteLine("Choose Mode:\n");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");


            int option = Convert.ToInt32(Console.ReadLine());


            if (option == 1)
            {
                AdditionMode();
            } 
            else if (option == 2)
            {
                SubtractionMode();
            } 
            else if (option == 3)
            {
                MultiplicationMode();
            } 
            else if (option==4)
            {
                DivisionMode();
            }
            

        }

        static void AdditionMode()
        {
            Random randomAdd = new Random(); // random class new instance
            int num1 = randomAdd.Next(99);
            int num2 = randomAdd.Next(99);
            Console.WriteLine($"{num1} + {num2}");

        }

        static void SubtractionMode()
        {
            Random randomSub = new Random(); // random class new instance
            int num1 = randomSub.Next(99);
            int num2 = randomSub.Next(99);
            Console.WriteLine($"{num1} - {num2}");
        }

        static void MultiplicationMode()
        {
            Random randomMult = new Random(); // random class new instance
            int num1 = randomMult.Next(99);
            int num2 = randomMult.Next(99);
            Console.WriteLine($"{num1} * {num2}");
        }

        static void DivisionMode()
        {
            Random randomDiv = new Random(); // random class new instance
            int num1 = randomDiv.Next(99);
            int num2 = randomDiv.Next(99);
            Console.WriteLine($"{num1} / {num2}");

        }
    }
}
