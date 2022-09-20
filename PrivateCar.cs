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

        public PrivateCar(bool IsHybrid, int DoorNumber, bool IsAC, bool IsMultimedia, bool IsMetallicColor, string Make, string Model, int Year, string Color, double Price, string Description) : base(DoorNumber, IsAC, IsMultimedia, IsMetallicColor, Make, Model, Year, Color, Price, Description)
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
            if (IsMetallicColor)
                price += 5000;
            if (IsMultimedia)
                price += 5000;
            if (!IsAC)
                price -= 5000;
            return price;
        }
    }
}
