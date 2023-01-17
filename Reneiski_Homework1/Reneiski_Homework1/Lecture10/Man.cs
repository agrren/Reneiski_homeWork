namespace Reneiski_Homework1.Lecture10
{
    public class Man : Human
    {
        public string ManName { get; set; }
        public Man(string firstname, string lastname) : base(firstname, lastname)
        {
            ManName = firstname;
        }

        public Man() : base("", "")
        {
        }
    }
}
