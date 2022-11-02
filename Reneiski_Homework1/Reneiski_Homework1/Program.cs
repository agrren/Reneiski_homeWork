// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hi! What's your name?");
//string name = Console.ReadLine();
//Console.WriteLine("Nice to meet you, " + name + "!");
//Console.ReadLine();

class Program
{
    static void Main(string[] args)
    {
        Task1();
    }
    private static void Task1()
    {
        var num = 20;
        Console.WriteLine($"Variable: {num += 5}");
        Console.ReadLine();
    }
    private static void Task2()
    {
        while (true)
        {
            Console.Clear();
            ushort number;
            try
            {
                Console.WriteLine("Please, give me a 4-number!");
                number = ushort.Parse(Console.ReadLine());
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



    private static void Task3()
    {
        while (true)
        {
            Console.Clear();
            double number;
            try
            {
                Console.WriteLine("Please, give me a number!");
                number = double.Parse(Console.ReadLine());
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
    private static void Task4()
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
    private static void Task5()
    {
        short maximumS = 32767;
        ulong maximumU = 18446744073709551615;
        char letterB = 'B';
        double maximumD = 1.76;

        Console.WriteLine(maximumD);
        Console.WriteLine(maximumU);
        Console.WriteLine(maximumS);
        Console.WriteLine(letterB);
    }
    private static void Task6()
    {
        sbyte number = -5;
        int result = number * 7;
        Console.WriteLine(--result);
    }
    private static void Task7()
    {
        while (true)
        {
            Console.Clear();
            double number;
            try
            {
                Console.WriteLine("Please, give me a number!");
                number = double.Parse(Console.ReadLine());
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
    private static void Task8()
    {
        while (true)
        {
            Console.Clear();
            double A;
            try
            {
                Console.WriteLine("Please, give me a number!");
                A = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("It is not a number!");
                Console.ReadLine();
                continue;
            }

            if (A < 50 && A != 37 && A >= 32 || A == 15 || A == 0)
                Console.WriteLine("Working");
            else
                Console.WriteLine("Not Working");
            Console.ReadLine();
        }
    }
    private static void Task9()
    {
        while (true)
        {
            Console.Clear();
            double A, B;
            
            try
            {
                Console.WriteLine("Please, give me A number!");
                A = double.Parse(Console.ReadLine());

                Console.WriteLine("Please, give me B number!");
                B = double.Parse(Console.ReadLine());
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
                    Console.WriteLine($"The sum is: {A + B}");
                    break;
                case ('-'):
                    Console.WriteLine($"The diff is: {A - B}");
                    break;
                case ('*'):
                    Console.WriteLine($"The prod is: {A * B}");
                    break;
                case ('/'):
                    Console.WriteLine($"The div is: {A / B}");
                    break;
                
            }
            Console.ReadLine();
        }
    }


}