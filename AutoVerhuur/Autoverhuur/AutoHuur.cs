using System;

namespace Autoverhuur
{
    public class AutoHuur
    {
        private int aantalDagen = 0;
        private Auto gehuurdeAuto;
        private Klant huurder;

        private string defStr1 = "er is geen auto bekend";
        private string defStr2 = "er is geen huurder bekend";
        private string defStr3 = "er is geen auto bekend";

        public AutoHuur()
        {
        }
        
        /* De setter, om de aantalDagen aan te passen in Program.cs */
        public void setAantalDagen(int aD)
        {
            aantalDagen = aD;
        }

        public void setGehuurdeAuto(Auto gA)
        {
            gehuurdeAuto = gA;
        }

        public Auto getGehuurdeAuto()
        {
            return gehuurdeAuto;
        }

        public void setHuurder(Klant k)
        {
            huurder = k;
        }

        public Klant getHuurder()
        {
            return huurder;
        }

        private double totaalPrijs()
        {
            if (huurder != null && gehuurdeAuto != null)
            {
                return (1.0 - huurder.getKorting() / 100.0) * gehuurdeAuto.getPrijsPerDag() * Convert.ToDouble(aantalDagen);
            }
            return 0.0;
        }

        public string toString()
        {   
            string string1 = $"{gehuurdeAuto?.toString() ?? defStr1} \n";
            string string2 = $"{huurder?.toString() ?? defStr2} \n";
            string string3 = $"{"aantal dagen: " + aantalDagen + " en dat kost " + totaalPrijs()} \n";
            return string1 + string2 + string3;
        }
    }
}