namespace Reneiski_Homework1.Lecture7.Task2
{
    interface IPotatoActions
    {
        public string Knife { get; set; }
        public string Grater { get; set; }

        public void PeelPotato();

        public void GratePotato();
    }
}
