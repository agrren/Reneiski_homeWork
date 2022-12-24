using Reneiski_Homework1.Lecture9;

namespace Reneiski_Homework1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Lists for Tasks
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
            List<string> strings = new List<string>() { "one", "two", "three", "five", "six", "seven", "eight", "nine", "ten" };

            //SumOfEvens(ints);
            //PrintWordOfLengthFive(strings);
            //PrintWordOfLengthLinq(strings);
            //LinkedListAddTen();
            //UniteTwoLinkedLists();

            //Напишите метод для нахождения суммы всех четных чисел в списке.
            //В Main создайте список, содержащий не менее 10 целых чисел, вызовите свой метод и выдите полученный результат.

            static void SumOfEvens(List<int> ints)
            {
                int sumOfEvens = 0;

                foreach (var item in ints)
                {
                    if (item % 2 == 0)
                    {
                        sumOfEvens += item;
                    }
                }
                Console.WriteLine(sumOfEvens);
            }

            //В Main создайте список строк, где содержатся слова разной длины.
            //Напишите статический метод для вывода каждого слова из списка, состоящего ровно из 5 букв.

            static void PrintWordOfLengthFive(List<string> strings)
            {
                foreach (var item in strings)
                {
                    if (item.Length == 5)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            //Измените свой код, чтобы предложить пользователю ввести длину слова для поиска. (через LINQ)
            static void PrintWordOfLengthLinq(List<string> strings)
            {
                Console.WriteLine("Please type the length");

                int lengthFromUser = int.Parse(Console.ReadLine());
                var lengthOfString = from l in strings where l.Length == lengthFromUser select l;

                foreach (var item in lengthOfString)
                {
                    Console.WriteLine(item);
                }
            }

            //Создайте LinkedList и два элемента, вставьте второй элемент после каждого вхождения первого элемента в списке.
            //Итак, если список равен [2,4,3,2,8,2,5,1,2], а элементы равны 2 и 10, результатом будет [2,10,4,3,2,10,8,2,10,5,1,2,10]

            static void LinkedListAddTen()
            {
                List<string> ints = new List<string>() { "2", "4", "3", "2", "8", "2", "5", "1", "2" };

                var linkedInts = new LinkedList<string>(ints);
                var twoNode = linkedInts.First;
                string tenNode = "10";

                while (twoNode != null)
                {
                    if (twoNode.Value == "2")
                    {
                        linkedInts.AddAfter(twoNode, tenNode);
                    }

                    Console.WriteLine(twoNode.Value);
                    twoNode = twoNode.Next;
                }
            }

            //Объединить два связанных списка чисел, включив в окончательный список только те числа, которые встречаются в обоих списка.
            //Итак, если списки [1,3,4,7,12] и [1,5,7,9], результат будет [1,7].

            static void UniteTwoLinkedLists()
            {
                List<string> intsOne = new List<string>() { "1", "3", "4", "7", "12" };
                List<string> intsTwo = new List<string>() { "1", "5", "7", "9" };

                var linkedIntsOne = new LinkedList<string>(intsOne);
                var linkedIntsTwo = new LinkedList<string>(intsTwo);

                var nodeOne = linkedIntsOne.First;
                var nodeTwo = linkedIntsTwo.First;

                var smth = from one in linkedIntsOne
                           from two in linkedIntsTwo
                           where one.Equals(two)
                           select two;

                foreach (var item in smth)
                {
                    Console.WriteLine(item);
                }
            }

            //Создайте Queue. Добавьте занчения в очередь с при помощи ввода с консоли.
            //Реализуйте операцию: GetMaxValue, которая возвращает максимальное значение, хранящееся в данный момент в очереди, не удаляя его.
            //Каждый раз, когда текущий максимум удаляется из очереди, операция GetMaxValue очереди должна отражать новый самый большой сохраненный элемент.

            var chisla = new List<int>() { 99, 15, 3 };
            Queue<int> numbers = new Queue<int>(chisla);

            //AddValueToQueue(ref numbers);
            //GetMaxValue(numbers);
            //MaxValueWithDelete(ref numbers);
            //GetMaxValue(numbers);

            static void AddValueToQueue(ref Queue<int> numbers)
            {
                Console.WriteLine("Please type values for queue");

                var value = int.Parse(Console.ReadLine());
                numbers.Enqueue(item: value);

                Console.WriteLine("Queue with added number");

                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }

            static void GetMaxValue(Queue<int> numbersMax)
            {
                Console.WriteLine();
                int? max = numbersMax.Max();
                Console.WriteLine($"Maximum number in the Queue: {max}");
            }

            static void MaxValueWithDelete(ref Queue<int> numbersMax)
            {
                var number1 = numbersMax.Dequeue();

                Console.WriteLine($"Maximum number to delete: {number1}");

                Console.WriteLine("Queue after deletion");

                foreach (var item in numbersMax)
                {
                    Console.WriteLine(item);
                }
            }

            //Напишите программу, которая принимает на вход три буквы и отображает их в обратном порядке. Используйте Stack.

            //StackAction();

            static void StackAction()
            {
                var bukva = new List<string>() { "a", "b", "c" };
                Stack<string> letters = new Stack<string>(bukva);

                foreach (Object item in letters)
                {
                    Console.WriteLine("{0}", item);
                }
            }

            //Добавьте новое значение, ключом которого является ваше имя, а значение — ваш возраст.
            //Сделайте это с помощью метода Add. Затем добавьте еще одно значение в словарь, используя нотацию индекса.
            //На этот раз используйте другое имя и другой возраст. Наконец, прочитайте первый элемент,
            //который вы добавили в словарь, и запишите его в консоль с помощью Console.WriteLine.

            //DictionaryFirstAction();

            static void DictionaryFirstAction()
            {
                Dictionary<string, int> people = new Dictionary<string, int>();

                people.Add("Sasha", 41);

                people["Petr"] = 38;

                var firstPerson = people.ElementAt(0);

                Console.WriteLine($"{firstPerson.Key}, {firstPerson.Value}");
            }

            //Создайте два списка, в каждом 10 значений.Первый список типа int, где значения заданы не по-порядку.Второй список типа string,
            //значения так же заданы не по алфавиту. Напишите метод, который совершает операции сортировки двух списков, списка int – по возрастанию,
            //списка string – по убыванию. Затем данный метод объединяет списки в словарь.Полученный словать выведите на консоль

            //DictionarySecondAction();

            static void DictionarySecondAction()
            {
                List<int> ints = new List<int>() { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };
                List<string> strings = new List<string>() { "a", "c", "e", "g", "i", "b", "d", "f", "h", "j" };

                var orderedInts = ints.OrderBy(p => p).ToList();

                foreach (var item in orderedInts)
                {
                    Console.WriteLine(item);
                }

                var oderedStrings = strings.OrderByDescending(p => p).ToList();

                foreach (var item in oderedStrings)
                {
                    Console.WriteLine(item);
                }

                var merged = orderedInts.Zip(oderedStrings, (key, value) => (key, value)).ToDictionary(p => p.key, p => p.value);

                foreach (var item in merged)
                {
                    Console.WriteLine(item);
                }
            }

            //Создайте класс City, где есть поля int население, double площадь.
            //Создайте словарь, где Key – название города, а Value – сооттветствующий названию города объект типа City.
            //Создайте 5 элементов для словаря. 
            //  a.Отсортируйте словарь по площади города и выведите на консоль
            //  b.Остортируйте словарь по населению в обратном порядке и выведите на консоль
            //  c.Подсчитайте общее население все городов и выведите на консоль

            var cities = new Dictionary<string, City>
            {
                {"Minsk", new City() { Population = 1975000, Square = 348.8 } },
                {"Gomel", new City() {Population = 508839, Square = 139.8} },
                {"Grodno", new City() {Population = 368710, Square = 142.1} },
                {"Vitebsk", new City() {Population = 362466, Square = 124.5} },
                {"Brest", new City() {Population = 343985, Square = 146.1} }
            };

            //PrintCitiesDict(cities);

            static void PrintCitiesDict(Dictionary<string, City> cities)
            {
                foreach (var item in cities.Keys)
                {
                    Console.WriteLine($"{item}, {cities[item].Population}, {cities[item].Square}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sort dictionary by Square");

            var sortedBySquare = cities.OrderBy(p => p.Value.Square);

            var printSortedBySquare = sortedBySquare.ToDictionary(p => p.Key, p => p.Value);

            //PrintCitiesDict(printSortedBySquare);

            Console.WriteLine();
            Console.WriteLine("Sort dictionary by Population");

            var sortedByPopulation = cities.OrderByDescending(p => p.Value.Population);

            var printsortedByPopulation = sortedByPopulation.ToDictionary(p => p.Key, p => p.Value);

            //PrintCitiesDict(printsortedByPopulation);

            Console.WriteLine();
            Console.WriteLine("Total Sum of Population");

            var sumOfPopulation = cities.Sum(p => p.Value.Population).ToString();
            Console.WriteLine(sumOfPopulation);            
        }
    }
}
