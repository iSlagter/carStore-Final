using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore_Final
{
    class Bicycle : TwoWheels
    { 
        //Getters && Setters
        public bool IsDiscBreak { get; set; }

        public Bicycle(bool IsDiscBreak, bool IsEngine, string Color, double Price, string Make, string Model, string Year, string Description) : base(IsEngine, Color, Price, Make, Model, Year, Description)
        {
            this.IsDiscBreak = IsDiscBreak;
        }

        // Overriding toString() method of String class
        public override string ToString()
        {
            return "Type: Bicycle, IsDiscBreak: " + IsDiscBreak + "\n" + base.ToString();
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
