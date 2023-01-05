namespace WorkerNamespace
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Person()
        {
        }

        public virtual void ShowPersonInfo()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
        }

        public virtual string GetPersonLastName() => lastName;

        public virtual string GetPersonFirstName() => firstName;
        
        public virtual int GetPersonAge() => age;        
    }
}
