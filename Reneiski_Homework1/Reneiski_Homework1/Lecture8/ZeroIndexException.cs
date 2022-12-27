namespace Reneiski_Homework1.Lecture8
{
    public class ZeroIndexException : Exception
    {
        public ZeroIndexException() : base("Index should no be equal to zero!")
        {
        }
    }
}
