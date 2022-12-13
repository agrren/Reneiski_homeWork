using Reneiski_Homework1.Lecture7.Task2;

namespace Reneiski_Homework1.Lecture7.Task1
{
    public class MashedPotato : Potato, PotatoParams
    {
        string weight = "1 kg";
        string form = "ball";

        public override void WayOfCooking() => Console.WriteLine("Boil and mash it!");        

        public override string CheckTheSort { get { return sortOfPotato; } set { sortOfPotato = value; } }

        public void CheckPotato() => BadPotato();        

        public void WeightPotato() => Console.WriteLine("Weight potato to define the exact weight");

        public void CutPotato() => Console.WriteLine("Cut potato to make the form you want");        

        public string Weight { get { return weight; } set { weight = value; } }

        public string Form { get { return form; } set { weight = value; } }
    }
}
