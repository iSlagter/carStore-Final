﻿using System;
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

        public Motorcycle(bool IsMaunalGear, bool IsEngine, string Make, string Model, int Year, string Color, double Price, string Description) : base(IsEngine, Make, Model, Year, Color, Price, Description)
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
