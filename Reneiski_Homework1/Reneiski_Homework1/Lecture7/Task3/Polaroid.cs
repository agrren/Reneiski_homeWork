using Reneiski_Homework1.Lecture7.Task3;
using Reneiski_Homework1.Lecture7.Task3.Interfaces;

namespace AutomationCources.Lecture_7.Homework
{
    public class Polaroid : Items, ITurnOnOff, IPhotoAction, IPrintAction
    {
        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
            this.modelName = modelName;
            this.price = price;
        }

        public Polaroid()
        {

        }

        public override string Description
        {
            get
            {
                return $"Price: {price}, model:{modelName}, number of pixels in camera: {numberOfPixelsInCamera}";
            }
        }

        public void TakePhoto() => Console.WriteLine("Press black button at the top and photo is ready");        

        public void Print() => Console.WriteLine("Printing...");        

        public void TurnOn() => Console.WriteLine("Press right side button");        

        public override void TunrnOff() => Console.WriteLine("Press Turn Off button");        
    }
}
