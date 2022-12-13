using Reneiski_Homework1.Lecture7.Task3;

namespace AutomationCources.Lecture_7.Homework
{
    public class Printer : Items, TurnOnOff, PrintAction
    {
        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight)
        {
            this.modelName = modelName;
            this.price = price;
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }

        public Printer()
        {

        }

        public override string Description
        {
            get
            {
                return $"Price: {price}, model:{modelName}";
            }
        }

        public void TurnOn() => Console.WriteLine("Press button at the top");        

        public void Print() => Console.WriteLine("Printing...");        

        public void TunrnOff() => Console.WriteLine("Press Turn Off button");        
    }
}
