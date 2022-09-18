using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore_Final
{
    class TwoWheels : Vehicle
    {

        //Getters && Setters
        public bool IsEngine { get; set; }
        public string Color { get; set; }
                
        public TwoWheels(bool IsEngine, string Color, double Price, string Make, string Model, string Year, string Description) : base(Make, Model, Year, Price, Description)
        {
            this.IsEngine = IsEngine;
            this.Color  = Color;
        }

        public override string ToString()
        {
            return "Base Type: Two Wheeles, IsEngine: " + IsEngine + ", color: " + Color + base.ToString();
        }

        //Return the price of the Two Color product
        public override double CalculatePrice()
        {
            return base.CalculatePrice();
        }
    }
}
