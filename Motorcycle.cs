using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore_Final
{
    class Motorcycle : TwoWheels
    {
        //Getters && Setters
        public bool IsMaunalGear { get; set; }

        public Motorcycle(bool IsMaunalGear, bool IsEngine, string Color, double Price, string Make, string Model, string Year, string Description) : base(IsEngine, Color, Price, Make, Model, Year, Description)
        {
            this.IsMaunalGear = IsMaunalGear;
        }
        // Overriding toString() method of String class
        public override string ToString()
        {
            return "Type: Motorcycle, IsMaunalGear: " + IsMaunalGear + "\n" + base.ToString();
        }
        //Return the price of the Motorcycle it add 1000 if IsMaunalGear to the price
        public override double CalculatePrice()
        {
            double price = base.CalculatePrice();
            if (IsMaunalGear)
                price += 1000;
            return price;
        }
    }
}
