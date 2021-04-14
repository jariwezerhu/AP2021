using System;

namespace GameShop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            
            int releaseJaar1 = now.Year - 1; // 1 jaar geleden
            int releaseJaar2 = now.Year - 2; // 2 jaar geleden
            
            Game g1 = new Game("Just Cause 3", releaseJaar1, 49.98);
            Game g2 = new Game("Need for Speed: Rivals", releaseJaar2, 45.99);
            Game g3 = new Game("Need for Speed: Rivals", releaseJaar2, 45.99);
            
            g1.setPrice(34.98);
            g2.setPrice(22.53);
            g3.setPrice(22.53);

            Persoon p1 = new Persoon("Eric", 200);
            Persoon p2 = new Persoon("Hans", 55);
            Persoon p3 = new Persoon("Arno", 185);
            
            p1.koop(g1);
            p1.koop(g2);
            p1.koop(g3);
            p2.koop(g2);
            p2.koop(g1);
            p3.koop(g3);
            
            Console.WriteLine("\n" + p1.toString());
            Console.WriteLine(p2.toString());
            Console.WriteLine(p3.toString());
            
            p1.sellGame(g1, p3);
            p2.sellGame(g2, p3);
            p2.sellGame(g1, p1);

            Console.WriteLine("\n" + p1.toString());
            Console.WriteLine(p2.toString());
            Console.WriteLine(p3.toString());
        }
    }
}