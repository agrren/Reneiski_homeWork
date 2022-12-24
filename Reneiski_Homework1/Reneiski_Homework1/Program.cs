using AutomationCources.Lecture_7.Homework;
using Reneiski_Homework1.Lecture7.Task1;

namespace Reneiski_Homework1
{
    public class Program
    {
        static void Main(string[] args)
        {
            MashedPotato mashedPotato = new MashedPotato();
            FriedPotato friedPotato = new FriedPotato();

            Console.WriteLine("===Mashed Potato===");
            mashedPotato.SortOfPotato() = "Kolobok";
            Console.WriteLine(mashedPotato.CheckedSortOfPotato);
            mashedPotato.Cook();
            mashedPotato.CheckPotato();
            mashedPotato.WeightPotato();
            mashedPotato.CutPotato();
            Console.WriteLine($"The weight is: {mashedPotato.Weight} and the form is: {mashedPotato.Form}");

            Console.WriteLine("===Fried Potato===");
            friedPotato.SortOfPotato() = "Skarb";
            Console.WriteLine(friedPotato.CheckedSortOfPotato);
            friedPotato.Cook();
            friedPotato.CheckPotato();
            friedPotato.PeelPotato();
            friedPotato.GratePotato();
            Console.WriteLine($"Use {friedPotato.Grater} for grating and {friedPotato.Knife} for cutting!");

            MobilePhone mobilePhone = new MobilePhone();
            Polaroid polaroid = new Polaroid();
            Printer printer = new Printer();

            Console.WriteLine("===Mobile Phone===");
            mobilePhone.numberOfPixelsInCamera = 100;
            mobilePhone.modelName = "IPhone13";
            mobilePhone.price = 800;
            Console.WriteLine(mobilePhone.Description);
            mobilePhone.TurnOn();
            mobilePhone.TakePhoto();
            mobilePhone.TunrnOff();

            Console.WriteLine("===Polaroid===");
            polaroid.numberOfPixelsInCamera = 150;
            polaroid.modelName = "Honey";
            polaroid.price = 300;
            polaroid.paperWidth = 10;
            polaroid.paperHeight = 12;
            Console.WriteLine(polaroid.Description);
            polaroid.TurnOn();
            polaroid.TakePhoto();
            polaroid.Print();
            polaroid.TunrnOff();

            Console.WriteLine("===Printer===");
            printer.modelName = "HP";
            printer.price = 500;
            printer.paperWidth = 100;
            printer.paperHeight = 120;
            Console.WriteLine(printer.Description);
            printer.TurnOn();
            printer.Print();
            printer.TunrnOff();
        }
    }
}
