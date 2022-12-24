namespace Reneiski_Homework1.Lecture7.Task2
{
    interface IPotatoParams
    {
        public string Weight { get; set; }
        public string Form { get; set; }

        public void WeightPotato();

        public void CutPotato();
    }
}
