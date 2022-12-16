namespace Reneiski_Homework1.Lecture7.Task1
{
    public abstract class Potato
    {
        private string? sortOfPotato;

        public ref string SortOfPotato()
        {
            return ref sortOfPotato;
        }

        public abstract void Cook();

        public abstract string CheckTheSort { get; set; }

        public void CheckIfBadPotato()
        {            
            Console.WriteLine("Type yes if the potato bad and no if not");
            var isBad = Console.ReadLine();

            if (isBad == "yes")
            {
                Console.WriteLine("Throw away!");
            }
            else Console.WriteLine("You can use it");
        }
    }
}
