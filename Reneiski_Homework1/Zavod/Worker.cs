namespace WorkerNamespace
{
    public class Worker
    {
        private string firstName;
        private string lastName;
        private int age;
        private string position;

        public Worker(string firstName, string lastName, int age, string position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.position = position;
        }

        public Worker()
        {
        }

        public ref string LastNameInfo()
        {
            return ref lastName;
        }

        public ref string PositionInfo()
        {
            return ref position;
        }

        public void ShowWorkerName()
        {            
            Console.WriteLine($"Name: {firstName} {lastName}");            
        }

        public void ShowWorkerAge()
        {
            Console.WriteLine($"Age: {age}");
        }

        public void ShowWorkerPosition()
        {
            Console.WriteLine($"Position: {position}");
        }

        public void ShowWorkerInfo()
        {
            Console.WriteLine("====Employee====");
            ShowWorkerName();
            ShowWorkerAge();
            ShowWorkerPosition();
        }
        
        public void ShowWorkerWork()
        {
            Console.WriteLine($"{position} works on {position}'s place!");
        }
    }
}
