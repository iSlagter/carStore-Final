using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore_Final
{
    class JeepCar : FourWheels
    {
        //Getters && Setters
        public bool Is4X4 { get; set; }

        public JeepCar(bool Is4X4, int DoorNumber, bool IsAC, bool IsMultimedia, string Make, string Model, string Year, double Price, string Description) : base(DoorNumber, IsAC, IsMultimedia, Make,  Model, Year, Price, Description)
        {
            this.Is4X4 = Is4X4;
        }
        // Overriding toString() method of String class
        public override string ToString()
        {
            return "Type: Jeep Car, Is4X4: " + Is4X4 + "\n" + base.ToString();
        }
        //Return the price of the JEEP it add 20000 if Is4X4 to the price
        public override double CalculatePrice()
        {
            double price = base.CalculatePrice();
            if (Is4X4)
                price += 20000;
            return price;
        }
    }
}
