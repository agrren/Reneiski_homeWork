namespace Reneiski_Homework1.Lecture3
{
    public class Lecture3Homework
    {
        public static void Task1()
        {
            var num = 20;

            Console.WriteLine($"Variable: {num += 5}");
            Console.ReadLine();
        }

        public static void Task2()
        {
            bool stopper = true;

            while (stopper == true)
            {
                Console.Clear();
                ushort number;

                try
                {
                    Console.WriteLine("Please, give me a 4-number!");
                    number = ushort.Parse(Console.ReadLine());
                    stopper = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number!");
                    Console.ReadLine();
                    continue;
                }

                var numberOfYears = number / 365;
                var numberOfMonths = (number - numberOfYears * 365) / 30;
                var numberOfDays = number - numberOfMonths * 30 - numberOfYears * 365;

                Console.WriteLine($"Number of years: {numberOfYears}");
                Console.WriteLine($"Number of month: {numberOfMonths}");
                Console.WriteLine($"Number of days: {numberOfDays}");
                Console.ReadLine();
            }
        }

        public static void Task3()
        {
            bool stopper = true;

            while (stopper == true)
            {
                Console.Clear();
                double number;

                try
                {
                    Console.WriteLine("Please, give me a number!");
                    number = double.Parse(Console.ReadLine());
                    stopper = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine($"Here is result! {number + number * 2}");
                Console.ReadLine();
            }
        }

        public static void Task4()
        {
            sbyte minus34 = -34;
            byte prosto4 = 4;
            string hello = "Hello";
            char letterR = 'R';
            double numberStochkoi = 23.093433222;
            ushort sorokTysach = 40000;
            bool istynno = true;
            byte zero = 0;

            Console.WriteLine(minus34);
            Console.WriteLine(prosto4);
            Console.WriteLine(hello);
            Console.WriteLine(letterR);
            Console.WriteLine(numberStochkoi);
            Console.WriteLine(sorokTysach);
            Console.WriteLine(istynno);
            Console.WriteLine(zero);
        }

        public static void Task5()
        {
            Console.WriteLine($"Please, enter 32767");
            short maximumS = short.Parse(Console.ReadLine());

            Console.WriteLine($"Please, enter 18446744073709551615");
            ulong maximumU = ulong.Parse(Console.ReadLine());

            Console.WriteLine($"Please, enter letter B");
            char letterB = char.Parse(Console.ReadLine());

            Console.WriteLine($"Please, enter 1.76");
            double maximumD = double.Parse(Console.ReadLine());

            Console.WriteLine(maximumD);
            Console.WriteLine(maximumU);
            Console.WriteLine(maximumS);
            Console.WriteLine(letterB);
        }

        public static void Task6()
        {
            sbyte number = -5;
            int result = number * 7;

            Console.WriteLine(--result);
        }

        public static void Task7()
        {
            bool stopper = true;

            while (stopper == true)
            {
                Console.Clear();
                double number;

                try
                {
                    Console.WriteLine("Please, give me a number!");
                    number = double.Parse(Console.ReadLine());
                    stopper = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number!");
                    Console.ReadLine();
                    continue;
                }

                if (number % 2 == 0)
                    Console.WriteLine("The number is even");
                else
                    Console.WriteLine("The number is odd");
                Console.ReadLine();
            }
        }

        public static void Task8()
        {
            bool stopper = true;

            while (stopper == true)
            {
                Console.Clear();
                double a;

                try
                {
                    Console.WriteLine("Please, give me a number!");
                    a = double.Parse(Console.ReadLine());
                    stopper = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number!");
                    Console.ReadLine();
                    continue;
                }

                if (a < 50 && a != 37 && a >= 32 || a == 15 || a == 0)
                    Console.WriteLine("Working");
                else
                    Console.WriteLine("Not Working");
                Console.ReadLine();
            }
        }

        public static void Task9()
        {
            bool stopper = true;

            while (stopper == true)
            {
                Console.Clear();
                double a, b;

                try
                {
                    Console.WriteLine("Please, give me A number!");
                    a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please, give me B number!");
                    b = double.Parse(Console.ReadLine());

                    stopper = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("It is not a number!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Please, select an action: +, -, *, /");
                char action = char.Parse(Console.ReadLine());

                switch (action)
                {
                    case ('+'):
                        Console.WriteLine($"The sum is: {a + b}");
                        break;
                    case ('-'):
                        Console.WriteLine($"The diff is: {a - b}");
                        break;
                    case ('*'):
                        Console.WriteLine($"The prod is: {a * b}");
                        break;
                    case ('/'):
                        Console.WriteLine($"The div is: {a / b}");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
