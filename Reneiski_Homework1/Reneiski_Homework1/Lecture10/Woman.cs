namespace Reneiski_Homework1.Lecture10
{
    public class Woman : Human
    {
        public string WomananName { get; set; }

        public Woman(string firstname, string lastname) : base(firstname, lastname)
        {
            WomananName = firstname;
        }

        public Woman() : base("", "")
        {
        }
    }
}
