namespace Reneiski_Homework1.Lecture7.Task3
{
    public abstract class Items
    {
        public double numberOfPixelsInCamera;
        public string? modelName;
        public decimal price;
        public int paperWidth;
        public int paperHeight;

        public abstract string Description { get; }

        public abstract void TunrnOff();        
    }
}
