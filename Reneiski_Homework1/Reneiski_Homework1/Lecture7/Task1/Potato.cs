namespace Reneiski_Homework1.Lecture7.Task1
{
    public abstract class Potato
    {
        public string? sortOfPotato;

        public abstract void WayOfCooking();

        public abstract string CheckTheSort { get; set; }

        public void BadPotato()
        {
            
            Console.WriteLine("Type yes if the potato bad and no if not");
            string ifBad = Console.ReadLine();

            if (ifBad == "yes")
            {
                Console.WriteLine("Throw away!");
            }
            else Console.WriteLine("You can use it");
        }
    }
}
