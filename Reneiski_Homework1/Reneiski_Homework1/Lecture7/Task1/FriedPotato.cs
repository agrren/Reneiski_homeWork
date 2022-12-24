using Reneiski_Homework1.Lecture7.Task2;

namespace Reneiski_Homework1.Lecture7.Task1
{
    public class FriedPotato : Potato, IPotatoActions
    {
        private string _typeOfKnife = "kukri";
        private string _typeOfGrater = "shredder";

        public override void Cook() => Console.WriteLine("Cut and Fry it!");        

        public override string CheckedSortOfPotato { get { return SortOfPotato(); } set { SortOfPotato() = value; } }

        public void CheckPotato() => CheckIfBadPotato();        

        public string Knife { get { return _typeOfKnife; } set { _typeOfKnife = value; } }

        public string Grater { get { return _typeOfGrater; } set { _typeOfGrater = value; } }

        public void PeelPotato() => Console.WriteLine($"Use {Knife} to peel potato");

        public void GratePotato() => Console.WriteLine($"Use {Grater} to grate potato");
    }
}
