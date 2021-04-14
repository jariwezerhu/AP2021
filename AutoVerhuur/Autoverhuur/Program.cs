using System;

namespace Autoverhuur
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AutoHuur ah1 = new AutoHuur();
            Console.WriteLine("Eerste autohuur: " + ah1.toString());
            
            Klant k = new Klant("Mijnheer de Vries");
            k.setKorting(10.0);
            ah1.setHuurder(k);
            Console.WriteLine("Eerste autohuur: " + ah1.toString());

            Auto a1 = new Auto("Peugeot 207", 50);
            ah1.setGehuurdeAuto(a1);
            ah1.setAantalDagen(4);
            Console.WriteLine("Eerste autohuur: " + ah1.toString());

            AutoHuur ah2 = new AutoHuur();
            Auto a2 = new Auto("Ferrari", 3500);
            ah2.setGehuurdeAuto(a2);
            ah2.setHuurder(k);
            ah2.setAantalDagen(1);
            Console.WriteLine("Tweede autohuur: " + ah2.toString());

            Console.WriteLine("Gehuurd: " + ah1.getGehuurdeAuto());
            Console.WriteLine("Gehuurd: " + ah2.getGehuurdeAuto());
        }
    }
}