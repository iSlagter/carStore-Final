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
            //Send a warn text that for to click on submit you need to fill all the fields
            this.LblWarning.Text = "Fill All Fields!";
        }

        //Fucntion to calculate the price of all the things that add to the product
        private void CalculatePrice()
        {
            //this.Warning.Text = "";
            int price = 0;
            if (ChkBoxMakeAndModel.SelectedItem != null)
            {
                string privateCar = this.ChkBoxMakeAndModel.SelectedItem.ToString();
                string year = this.ChkBoxYear.SelectedItem.ToString();


                //Add the price by the Make, Model and Year of the Private Car
                switch (privateCar)
                {
                    case "Toyota, Corolla":
                        switch (year)
                        {
                            case "2015":
                                price += 99000;
                                break;
                            case "2016":
                                price += 102000;
                                break;
                            case "2017":
                                price += 105000;
                                break;
                            case "2018":
                                price += 120000;
                                break;
                            case "2019":
                                price += 160000;
                                break;
                            case "2020":
                                price += 175000;
                                break;
                            case "2021":
                                price += 185000;
                                break;
                            case "2022":
                                price += 250000;
                                break;
                        }
                        break;
                    case "Kia, Picanto":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;
                    case "Hyundai, Ionic":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;
                    case "Tesla, Model 3":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;
                    case "BMW, M2":
                        switch (year)
                        {
                            case "2015":
                                price = 99000;
                                break;
                            case "2016":
                                price = 102000;
                                break;
                            case "2017":
                                price = 105000;
                                break;
                            case "2018":
                                price = 120000;
                                break;
                            case "2019":
                                price = 160000;
                                break;
                            case "2020":
                                price = 175000;
                                break;
                            case "2021":
                                price = 185000;
                                break;
                            case "2022":
                                price = 250000;
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            if (this.ChkBoxIsMultimedia.Checked)
                price += 5000;
            if (this.ChkBoxIsHybrid.Checked)
                price += 8000;
            if (this.ChkBoxIsMetallicColor.Checked)
                price += 5000;

            this.LblTotalPrice.Text = price.ToString();

        }
        private void ChkBoxMakeAndModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChkBoxMakeAndModel.SelectedIndex;
            int count = ChkBoxMakeAndModel.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    ChkBoxMakeAndModel.SetItemCheckState(x, CheckState.Unchecked);
                }
            }

        }

        private void ChkBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChkBoxYear.SelectedIndex;
            int count = ChkBoxYear.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    ChkBoxYear.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }

        private void ChkBoxDoorNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChkBoxDoorNumber.SelectedIndex;
            int count = ChkBoxDoorNumber.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    ChkBoxDoorNumber.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }

        private void ChkBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ChkBoxColor.SelectedIndex;
            int count = ChkBoxColor.Items.Count;
            for (int x = 0; x < count; x++)
            {
                if (index != x)
                {
                    ChkBoxColor.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }

        private void ChkBoxIsHybrid_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void ChkBoxIsMultimedia_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void ChkBoxIsMetallicColor_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void OrderPrivateCar_Load(object sender, EventArgs e)
        {

        }

        protected void OnContentChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void OnContentChanged(object sender, ItemCheckEventArgs e)
        {
            CalculatePrice();
        }
    }
}
