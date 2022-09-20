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
                
        public TwoWheels(bool IsEngine, string Make, string Model, int Year, string Color, double Price, string Description) : base(Make, Model, Year, Color, Price, Description)
        {
            this.IsEngine = IsEngine;
        }

        public override string ToString()
        {
            return "Base Type: Two Wheeles, IsEngine: " + IsEngine + base.ToString();
        }

        //Return the price of the Two Color product
        public override double CalculatePrice()
        {
            return base.CalculatePrice();
        }
    }
}
