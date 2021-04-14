using System;
using System.IO.Pipes;

namespace GameShop
{
    public class Game
    {
        private string name;
        private int releaseYear;
        private double newPrice;
        private double price;
        public Game(string Name, int Year, double NewPrice)
        {
            name = Name;
            releaseYear = Year;
            newPrice = NewPrice;
            price = newPrice;
        }

        public void setPrice(double Price)
        {
            price = Price;
        }
        public double getGamePrice()
        {
            return price;
        }

        public string getGameName()
        {
            return name;
        }

        public string toString()
        {
            return $"{name}, uitgegeven in {releaseYear}; nieuwprijs: {newPrice} nu voor: \u20AC{price}";
        }
    }
}