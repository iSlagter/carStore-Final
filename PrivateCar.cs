using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore_Final
{
    class PrivateCar : FourWheels
    {        
        //Getters && Setters
        public bool IsHybrid { get; set; }

        public PrivateCar(bool IsHybrid, int DoorNumber, bool IsAC, bool IsMultimedia, double Price, string Make, string Model, string Year, string Description) : base(DoorNumber, IsAC, IsMultimedia, Price, Make,  Model, Year, Description)
        {
            this.IsHybrid = IsHybrid;
        }
        // Overriding toString() method of String class
        public override string ToString()
        {
            return "Type: Private Car, IsHybrid: " + IsHybrid + "\n" + base.ToString();
        }
        //Return the price of the Private Car it add 8000 if IsHybrid to the price
        public override double CalculatePrice()
        {
            double price = base.CalculatePrice();
            if (IsHybrid)
                price += 8000;
            return price;
        }
    }
}
