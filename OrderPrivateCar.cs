using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carStore_Final
{
    internal partial class OrderPrivateCar : Form
    {
        public Vehicle PrivateCar = null;
        public OrderPrivateCar()
        {
            InitializeComponent();
        }

        //Check true if all the input is fill
        private bool IsEverythingFilled()
        {
            int IsFilled = 0;
            IsFilled += this.ChkBoxMakeAndModel.SelectedItem == null ? 1 : 0;
            IsFilled += this.ChkBoxYear.SelectedItem == null ? 1 : 0;
            IsFilled += this.ChkBoxColor.SelectedItem == null ? 1 : 0;
            IsFilled += this.ChkBoxDoorNumber.SelectedItem == null ? 1 : 0;

            return IsFilled == 0;
        }

        private void BtnSubmitPrivateCar_Click(object sender, EventArgs e)
        {
            if (IsEverythingFilled())
            {
                bool IsHybrid = false;
                int DoorNumber = 0;
                bool IsAC = true;
                bool IsMultimedia = false;
                bool IsMetallicColor = false;
                var MakeAndModel = this.ChkBoxMakeAndModel.SelectedItem.ToString();
                string[] MakeModel = MakeAndModel.Split(",");
                string Make = MakeModel[0];
                string Model = MakeModel[1];
                int Year = int.Parse(this.ChkBoxYear.SelectedItem.ToString());
                string Color = this.ChkBoxColor.SelectedItem.ToString();
                double Price = 0;
                switch (MakeAndModel)
                {
                    case "Toyota, Corolla":
                        switch (Year)
                        {
                            case 2015:
                                Price += 99000;
                                break;
                            case 2016:
                                Price += 102000;
                                break;
                            case 2017:
                                Price += 105000;
                                break;
                            case 2018:
                                Price += 120000;
                                break;
                            case 2019:
                                Price += 160000;
                                break;
                            case 2020:
                                Price += 175000;
                                break;
                            case 2021:
                                Price += 185000;
                                break;
                            case 2022:
                                Price += 250000;
                                break;
                        }
                        break;
                    case "Kia, Picanto":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    case "Hyundai, Ionic":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    case "Tesla, Model 3":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    case "BMW, M2":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    case "Yamaha, Tmax":
                        switch (Year)
                        {
                            case 2015:
                                Price = 99000;
                                break;
                            case 2016:
                                Price = 102000;
                                break;
                            case 2017:
                                Price = 105000;
                                break;
                            case 2018:
                                Price = 120000;
                                break;
                            case 2019:
                                Price = 160000;
                                break;
                            case 2020:
                                Price = 175000;
                                break;
                            case 2021:
                                Price = 185000;
                                break;
                            case 2022:
                                Price = 250000;
                                break;
                        }
                        break;
                    default:
                        break;
                }
                string Description = "Good Bicycle Good Price Only Today Good Discount";


                this.PrivateCar = new PrivateCar(IsHybrid, DoorNumber, IsAC, IsMultimedia, IsMetallicColor, Make, Model, Year, Color, Price, Description);
                this.DialogResult = DialogResult.OK;
                //Close the form
                this.Close();
            }
        }

        //Fucntion to calculate the price of all the things that add to the product
        private void CalculatePrice()
        { 

        }
        private void ChkBoxMakeAndModel_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
    }
}
