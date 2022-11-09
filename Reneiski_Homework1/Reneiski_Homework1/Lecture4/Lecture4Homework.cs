namespace Reneiski_Homework1.Lecture4
{
    public class Lecture4Homework
    {
        public static void Task1()
        {
            bool isCorrect = true;

            while (isCorrect)
            {
                Console.Clear();
                uint dNumber;

                try
                {
                    Console.WriteLine("Please, enter a possitive number");
                    dNumber = uint.Parse(Console.ReadLine());
                    isCorrect = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Hey! It's not a number!");
                    Console.ReadLine();
                    continue;
                }

                uint sum = 0;

                for (uint i = 0; i <= dNumber; i++)
                {
                    sum += i;
                }

                Console.WriteLine(sum);
                Console.ReadLine();
            }
        }

        public static void Task2()
        {
            int number = 0;

            while (number <= 10)
            {
                Console.WriteLine($"3 * {number} = {3 * number}");
                number++;
            }

            Console.ReadLine();
        }

        public static void Task3()
        {
            int[] numbers = { 3, 5, 9, 8, 15 };
            int prod = 1;

            for (int i = 0; i < 5; i++)
            {
                prod *= numbers[i];
            }

            Console.WriteLine(prod);
            Console.ReadLine();
        }

        public static void Task4()
        {
            int number = 2048;
            int count = 0;

            for (int i = 1; number > 10; i++)
            {
                number /= 2;
                count = i;
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static void Task5()
        {
            string[] strings = { "Privet", "Nihao", "Sveiki", "Hello", "Namaste" };

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == "Hello")
                    break;
                else
                    Console.WriteLine($"{strings[i]} It is not Hello!");
            }

            Console.WriteLine("Labas!");
            Console.ReadLine();
        }

        public static void Task6()
        {
            int[] numbers = { 3, 5, 9, 8, 15 };
            int sum = numbers[0] + numbers[numbers.Length - 1];
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static void Task7()
        {
            int[] numbers = { 24, 3, 5, 9, 8, 15, 1 };
            int min = numbers[0];
            int max = numbers[0];
            int minCount = 0;
            int maxCount = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    minCount = i;
                    min = numbers[i];
                    Console.WriteLine($"{min} and {minCount}");
                }
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    maxCount = i;
                    max = numbers[i];
                    Console.WriteLine($"{max} and {maxCount}");
                }
            }
            Console.WriteLine(minCount + maxCount);
            Console.ReadLine();
        }

        public static void Task8()
        {
            int[] numbers = { 24, 3, 5, 9, 8, 15, 7, 8 };
                        
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }                    
                }                
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }

        public static void Task9()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }

            Console.ReadLine();
        }
    }
}
