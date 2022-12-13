using Reneiski_Homework1.Lecture7.Task2;

namespace Reneiski_Homework1.Lecture7.Task1
{
    public class FriedPotato : Potato, PotatoActions
    {
        string typeOfKnife = "kukri";
        string typeOfGrater = "shredder";

        public override void WayOfCooking() => Console.WriteLine("Cut and Fry it!");        

        public override string CheckTheSort { get { return sortOfPotato; } set { sortOfPotato = value; } }

        public void CheckPotato() => BadPotato();        

        public string Knife { get { return typeOfKnife; } set { typeOfKnife = value; } }

        public string Grater { get { return typeOfGrater; } set { typeOfGrater = value; } }

        public void PeelPotato() => Console.WriteLine($"Use {Knife} to peel potato");

        public void GratePotato() => Console.WriteLine($"Use {Grater} to grate potato");
    }
}
