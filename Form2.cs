using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace carStore_Final
{
    public partial class Form2 : Form
    {
        List<Vehicle> Vehicles = new List<Vehicle>();
        List<Label> VehiclesMakes = new List<Label>();
        List<Label> VehiclesModels = new List<Label>();
        List<Label> VehiclesYears = new List<Label>();
        List<Label> VehiclesColors = new List<Label>();
        List<Label> VehiclesPrices = new List<Label>();
        List<Button> VehiclesDeletes = new List<Button>();

        public Form2()
        {
            InitializeComponent();
        }
        public void RenderComponents()
        {
            VehiclesMakes.Clear();
            VehiclesModels.Clear();    
            VehiclesYears.Clear();
            VehiclesColors.Clear();
            VehiclesPrices.Clear();
            VehiclesDeletes.Clear();

            int left = 50;
            int top = 400;

            //Run on all the product that we order add to them a name and price and the function of delete
            for (int i = 0; i < this.Vehicles.Count; i++)
            {
                VehiclesMakes.Add(new Label
                {
                    Text = this.Vehicles[i].Make,
                    Location = new Point(left, top),
                    Name = "VehicleMake" + i
                });

                VehiclesMakes.Add(new Label
                {
                    Text = this.Vehicles[i].Model,
                    Location = new Point(left, top),
                    Name = "VehicleModel" + i
                });

                VehiclesMakes.Add(new Label
                {
                    Text = this.Vehicles[i].Year.ToString(),
                    Location = new Point(left, top),
                    Name = "VehicleYear" + i
                });

                VehiclesMakes.Add(new Label
                {
                    Text = this.Vehicles[i].Color,
                    Location = new Point(left, top),
                    Name = "VehicleColors" + i
                });


                left = 330;
                VehiclesPrices.Add(new Label
                {
                    Text = this.Vehicles[i].CalculatePrice().ToString(),
                    Location = new Point(left, top),
                    Name = "VehiclePrice" + i
                });

                left = 430;
                VehiclesDeletes.Add(new Button
                {
                    Text = "Delete",
                    Location = new Point(left, top),
                    Name = "VehicleDelete" + i,
                    AccessibleName = i.ToString(),
                });
                VehiclesDeletes[i].Click += new EventHandler(Delete_Click);


                left = 50;
                top += 30;

            }
            for (int i = 0; i < this.Vehicles.Count; i++)
            {
                this.Controls.Add(VehiclesMakes[i]);
                this.Controls.Add(VehiclesModels[i]);
                this.Controls.Add(VehiclesYears[i]);
                this.Controls.Add(VehiclesColors[i]);
                this.Controls.Add(VehiclesPrices[i]);
                this.Controls.Add(VehiclesDeletes[i]);
            }

            //Take a total of all the Vehicles that you order and make a sum of the total price oreder
            double TotalPrice = 0;
            foreach (Vehicle vehicle in this.Vehicles)
            {
                TotalPrice += vehicle.CalculatePrice();
            }
            this.LblTotalPrice.Text = TotalPrice.ToString();
        }

        //Delete button when You want to remove a Vehicle from the order
        private void Delete_Click(object sender, EventArgs e)
        {
            Button CurrentButton = (Button)sender;
            string StrName = CurrentButton.AccessibleName;
            int ButtonIndex = int.Parse(StrName);

            //Need to find the product and delete it from the controls, search by name
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];
                if (control.Name.StartsWith("Vehicle"))
                    control.Dispose();
            }

            this.Vehicles.RemoveAt(ButtonIndex);

            //refresh
            this.RenderComponents();
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOrderJeep_Click(object sender, EventArgs e)
        {
            /*
            OrderJeep orderJeep = new OrderJeep();
            orderJeep.ShowDialog();
            */
            
            using (var form = new OrderJeep())
            {
                var Result = form.ShowDialog();
                if (Result == DialogResult.OK)
                {
                    //Add the new order of cocktail to the products
                    this.Vehicles.Add(form.JeepCar);
                    RenderComponents();
                }
            }
            

        }

        private void BtnSaveOrder_Click(object sender, EventArgs e)
        {

            //Create a filename a empty path 
            string FileName = "CarStoreOrder.json";
            string FilePath = "";
            DialogResult result;
            //Open a window to FolderBrowser to choose the location path for the file
            using (var fbd = new FolderBrowserDialog())
            {
                //Take the result path
                result = fbd.ShowDialog();
                //Check if the path is fine
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //Make the full filepath with the fileName
                    FilePath = fbd.SelectedPath + "\\" + FileName;
                    //Check if the file is alredy exist if not so create
                    if (!File.Exists(FilePath))
                    {
                        //Create a file
                        //using (var h = File.Create(FilePath)) ;
                    }
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects

                    };
                    //Use Serialized and json convert to make the SerializeObject on the products in the order
                    string Serialized = JsonConvert.SerializeObject(this.Vehicles, settings);
                    //Write to the new file the data of the order
                    File.WriteAllText(FilePath, Serialized);
                    //Clear and delete the products from the form
                    for (int i = this.Controls.Count - 1; i >= 0; i--)
                    {
                        Control control = this.Controls[i];
                        if (control.Name.StartsWith("Vehicle"))
                            control.Dispose();
                    }
                    this.Vehicles.Clear();
                    //RenderComponents();
                }

            }
        }

        private void BtnOrderPrivateCar_Click(object sender, EventArgs e)
        {
            OrderPrivateCar orderPrivateCar = new OrderPrivateCar();
            orderPrivateCar.ShowDialog();
        }

        private void BtnOrderMotorcycle_Click(object sender, EventArgs e)
        {
            OrderMotorcycle orderMotorcycle = new OrderMotorcycle();
            orderMotorcycle.ShowDialog();
        }

        private void BtnOrderBicycle_Click(object sender, EventArgs e)
        {
            OrderBicycle orderBicycle = new OrderBicycle();

            orderBicycle.ShowDialog();
        }

        private void BtnLoadOrder_Click(object sender, EventArgs e)
        {

        }

        private void LblTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
