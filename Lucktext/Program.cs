using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");

            string namn;

            namn = Console.ReadLine();

            Console.WriteLine("Om du fick en katt vad skulle den heta?");

            string katt;

            katt = Console.ReadLine();

            Console.WriteLine("Vad är din favoriträtt?");

            string mat;

            mat = Console.ReadLine();

            Console.WriteLine("Vad identifierar du dig som?");

            string kön;

            kön = Console.ReadLine();

            Console.WriteLine("Vad är ditt pronomen?");

            string pronomen;

            pronomen = Console.ReadLine();

            Console.WriteLine("Ok du kommer nu vara del av din bästa dag någonsin");

            Console.WriteLine("Det var en gång en " + kön + " som hette " + namn + "." + "En dag rinde de på " + pronomen + "s dörr. Utanför dörren låg en liten kattunge och " + pronomen + " döpte den till " + katt + ". Sedan gick de och käkade " + mat + " och det var gott o najs. Slut!");




            Console.ReadLine();



        }
    }
}
