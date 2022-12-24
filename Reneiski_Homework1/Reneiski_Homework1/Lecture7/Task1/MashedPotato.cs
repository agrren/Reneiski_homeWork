using Reneiski_Homework1.Lecture7.Task2;

namespace Reneiski_Homework1.Lecture7.Task1
{
    public class MashedPotato : Potato, IPotatoParams
    {
        private string _weight = "1 kg";
        private string _form = "ball";

        public override void Cook() => Console.WriteLine("Boil and mash it!");        

        public override string CheckedSortOfPotato { get { return SortOfPotato(); } set { SortOfPotato() = value; } }

        public void CheckPotato() => CheckIfBadPotato();        

        public void WeightPotato() => Console.WriteLine("Weight potato to define the exact weight");

        public void CutPotato() => Console.WriteLine("Cut potato to make the form you want");        

        public string Weight { get { return _weight; } set { _weight = value; } }

        public string Form { get { return _form; } set { _weight = value; } }
    }
}
