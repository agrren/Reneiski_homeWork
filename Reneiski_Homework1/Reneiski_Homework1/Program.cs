using Reneiski_Homework1.Lecture10;

namespace Reneiski_Homework1
{
    public class Program
    {
        static void Main()
        {
            var example = ManWoman<Man>(3);
            example.ToString();
        }

        static Generic<T> ManWoman<T>(int number) where T : Human
        {
            var ex = new Generic<T>(number);
            return ex;
        }
    }
}
