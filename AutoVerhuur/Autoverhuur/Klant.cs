using System;

namespace Autoverhuur
{
    public class Klant
    {
        private string naam;
        private double kortingsPercentage = 0.00;

        public Klant(string nm)
        {
            naam = nm;
        }

        public void setKorting(double kP)
        {
            kortingsPercentage = kP;
        }

        public double getKorting()
        {
            return kortingsPercentage;
        }

        public string toString()
        {
            return "op naam van: " + naam + " (korting: " + kortingsPercentage + "%)";
        }
    }
}