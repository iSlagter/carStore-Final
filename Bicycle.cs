using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace carStore_Final
{
    class Bicycle : TwoWheels
    { 
        //Getters && Setters
        public string Kind  { get; set; }
        public bool IsDiscBreak { get; set; }
        public int NumberGears  { get; set; }

        public Bicycle(string Kind,bool IsDiscBreak, int NumberGears, bool IsEngine, string Make, string Model, int Year, string Color, double Price, string Description) : base(IsEngine, Make, Model, Year, Color, Price, Description)
        {
            this.Kind = Kind;
            this.IsDiscBreak = IsDiscBreak;
            this.NumberGears = NumberGears;
        }

        // Overriding toString() method of String class
        public override string ToString()
        {
            return "Type: Bicycle, Kind: " + Kind + ", IsDiscBreak: " + IsDiscBreak + ", NumberGear: " + NumberGears + "\n" + base.ToString();
        }
        //Return the price of the Bicycle it add 900 if IsDiscBreak to the price
        public override double CalculatePrice()
        {
            double price = base.CalculatePrice();
            if (IsDiscBreak)
                price += 900;
            return price;
        }
    }
}
