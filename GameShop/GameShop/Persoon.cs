using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;

namespace GameShop
{
    public class Persoon
    {
        private string name;
        private double balance;
        private List<Game> games = new List<Game>();
        private List<string> gameNames = new List<string>();
        
        public Persoon(string Name, double Balance)
        {
            name = Name;
            balance = Balance;
        }

        public void koop(Game game)
        {
            if (balance > game.getGamePrice())
            {
                if (!gameNames.Contains(game.getGameName()))
                {
                    games.Add(game);
                    gameNames.Add(game.getGameName());
                    balance -= game.getGamePrice();
                    Console.WriteLine("gelukt");
                }
                else
                {
                    Console.WriteLine("niet gelukt");
                }
            }
            else
            {
                Console.WriteLine("niet gelukt");
            }
        }

        public double getBalance()
        {
            return balance;
        }

        public string getName()
        {
            return name;
        }

        public List<string> getGameList()
        {
            return gameNames;
        }

        public void addGame(Game game)
        {
            gameNames.Add(game.getGameName());
            games.Add(game);
        }

        public void changeBalance(double price)
        {
            balance -= price;
        }
        
        public void sellGame(Game game, Persoon persoon)
        {
            Console.Write($"{name} verkoopt {game.getGameName()} aan {persoon.getName()}: ");
            if (persoon.getBalance() > game.getGamePrice())
            {
                if (!persoon.getGameList().Contains(game.getGameName()))
                {
                    games.Remove(game);
                    gameNames.Remove(game.getGameName());
                    persoon.addGame(game);
                    persoon.changeBalance(game.getGamePrice());
                    balance += game.getGamePrice();
                    Console.WriteLine("gelukt");
                }
                else
                {
                    Console.WriteLine("niet gelukt");
                }
            }
            else
            {
                Console.WriteLine("niet gelukt");
            }
        }
        
        public string toString()
        {
            string string1 = $"{name} heeft een budget van \u20AC{balance} en bezit de volgende games: \n";
            string string2 = "";
            foreach (var game in games)
            {
                string2 += game.toString() + "\n";
            }

            return string1 + string2;
        }
    }
}