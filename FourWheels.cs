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
        public bool IsMetallicColor { get; set; }

        public FourWheels(int DoorNumber, bool IsAC, bool IsMultimedia, bool IsMetallicColor, string Make, string Model, int Year, string Color, double Price, string Description) : base(Make, Model, Year, Color, Price, Description)
        {
            this.DoorNumber = DoorNumber;
            this.IsAC = IsAC;
            this.IsMultimedia = IsMultimedia;
            this.IsMetallicColor = IsMetallicColor;
        }

        // Overriding toString() method of String class
        public override string ToString()
        {
            return "Base Type: FourWheeles, Door Number: " + DoorNumber + ", IsAC: " + IsAC + ", IsMultimedia: " + IsMultimedia + ", IsMetallicColor: " + IsMetallicColor +  "\n" + base.ToString();
        }
        //Return the price of the four wheel vehicle
        public override double CalculatePrice()
        {
            return base.CalculatePrice();
        }
    }
}
