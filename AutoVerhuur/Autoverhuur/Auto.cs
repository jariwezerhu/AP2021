namespace Autoverhuur
{
    public class Auto
    {
        /* De variabelen die bij een auto horen moeten private zijn */
        private string type;
        private double prijsPerDag = 0.00;
        
        
        /* De constructor om in Program.cs een nieuw object Auto aan te maken */
        public Auto(string tp, double prPd)
        {
            type = tp;
            prijsPerDag = prPd;
        }

        /* De setter, om de prijsPerDag aan te passen in Program.cs */
        public void setPrijsPerDag(double prPd)
        {
            prijsPerDag = prPd;
        }

        /* De getter, om de prijsPerDag terug te krijgen in Program.cs */
        public double getPrijsPerDag()
        {
            return prijsPerDag;
        }

        /* De toString om alles in een string te concatinaten */
        public string toString()
        {
            return "autotype: " + type + " met prijs per dag: " + prijsPerDag;
        }

        public override string ToString()
        {
            return type + " met prijs per dag: " + prijsPerDag;
        }
    }
}