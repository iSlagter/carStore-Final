using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*+----------------------------------------------------------------------
 ||
 ||  Class Product
 ||
 ||         Author:  Dor Slagter 
 ||
 ||        Purpose:  This class is hold the new Vehicle that we create this is the base class.
 ||
 ||  Inherits From:  None
 ||
 ||     Interfaces:  None
 ||
 |+-----------------------------------------------------------------------
 ||
 ||      Constants:  None
 ||
 |+-----------------------------------------------------------------------
 ||
 ||   Constructors:  Vehicle(double Price, string Make, string Year, string Description, string Model)
 ||
 ||  Class Methods:  double Price(), string Model(), string Description(), int ProductId()
 ||
 ||  Inst. Methods:  *static int count(), string ToString(), double CalculatePrice()
 ||
 ++-----------------------------------------------------------------------*/

namespace carStore_Final
{
    class Vehicle
    {
        private static int Count = 0;

        // Getters && Setters
        public double Price { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
        public int ProductId { get; }

        // Constructor : Parameterized
        public Vehicle(string Make, string Model, string Year, double Price, string Description)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            this.Description = Description;
            //The product id of the new product is the count number.
            this.ProductId = Count;
            //Add the count of the products when product create (count is statis)
            Count++;
        }
        //This function return the count of the products
        public static int count()
        {
            return Count;
        }
        // Overriding toString() method of String class
        public override string ToString()
        {
            return "Make: " + Make + ", Model: " + Model + ", Year: " + Year + ", Price: " + Price + ", Description: " + Description + ", ProductId: " + ProductId;
        }
        //Return the price of the product
        public virtual double CalculatePrice()
        {
            return Price;
        }
    }

}
