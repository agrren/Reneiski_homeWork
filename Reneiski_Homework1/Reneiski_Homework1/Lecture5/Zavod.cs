using WorkerNamespace;

namespace Reneiski_Homework1.Lecture5
{
    public class Zavod
    {
        public Worker? Engineer;
        public Worker? Building;

        public string Name;
        public string Description;
        public int HightOftube;
        public string NameOfbuilding;

        public Zavod(Worker? engineer, string name, string description)
        {
            Engineer = engineer;
            Name = name;
            Description = description;
        }

        public Zavod(Worker? building, int hightOftube, string nameOfbuilding) 
        {
            Building = building;
            HightOftube = hightOftube;
            NameOfbuilding = nameOfbuilding;
        }
    }
}
