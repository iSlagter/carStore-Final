using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore_Final
{
    class FourWheels : Vehicle
    {
        //Getters && Setters
        public int DoorNumber { get; set; }
        public bool IsAC { get; set; }
        public bool IsMultimedia { get; set; }    

        public FourWheels(int DoorNumber, bool IsAC, bool IsMultimedia, double Price, string Make, string Model, string Year, string Description) : base(Price, Make, Model, Year, Description)
        {
            this.DoorNumber = DoorNumber;
            this.IsAC = IsAC;
            this.IsMultimedia = IsMultimedia;
        }

        // Overriding toString() method of String class
        public override string ToString()
        {
            return "Base Type: FourWheeles, Door Number: " + DoorNumber + ", IsAC: " + IsAC + "IsMultimedia: " +IsMultimedia + "\n" + base.ToString();
        }
        //Return the price of the four wheel vehicle
        public override double CalculatePrice()
        {
            return base.CalculatePrice();
        }
    }
}
