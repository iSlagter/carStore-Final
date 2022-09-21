namespace carStore_Final
{
    partial class OrderPrivateCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSubmitPrivateCar = new System.Windows.Forms.Button();
            this.ChkBoxMakeAndModel = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxColor = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxYear = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxDoorNumber = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxIsHybrid = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.ChkBoxIsMultimedia = new System.Windows.Forms.CheckBox();
            this.ChkBoxIsMetallicColor = new System.Windows.Forms.CheckBox();
            this.LblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(231, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Private Car";
            // 
            // BtnSubmitPrivateCar
            // 
            this.BtnSubmitPrivateCar.Location = new System.Drawing.Point(656, 533);
            this.BtnSubmitPrivateCar.Name = "BtnSubmitPrivateCar";
            this.BtnSubmitPrivateCar.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmitPrivateCar.TabIndex = 1;
            this.BtnSubmitPrivateCar.Text = "Submit";
            this.BtnSubmitPrivateCar.UseVisualStyleBackColor = true;
            this.BtnSubmitPrivateCar.Click += new System.EventHandler(this.BtnSubmitPrivateCar_Click);
            // 
            // ChkBoxMakeAndModel
            // 
            this.ChkBoxMakeAndModel.FormattingEnabled = true;
            this.ChkBoxMakeAndModel.Items.AddRange(new object[] {
            "Toyota, Corolla",
            "Kia, Picanto",
            "Hyundai, Ionic",
            "Tesla, Model 3",
            "BMW, M2"});
            this.ChkBoxMakeAndModel.Location = new System.Drawing.Point(69, 93);
            this.ChkBoxMakeAndModel.Name = "ChkBoxMakeAndModel";
            this.ChkBoxMakeAndModel.Size = new System.Drawing.Size(120, 94);
            this.ChkBoxMakeAndModel.TabIndex = 2;
            this.ChkBoxMakeAndModel.SelectedIndexChanged += new System.EventHandler(this.ChkBoxMakeAndModel_SelectedIndexChanged);
            // 
            // ChkBoxColor
            // 
            this.ChkBoxColor.FormattingEnabled = true;
            this.ChkBoxColor.Items.AddRange(new object[] {
            "Black",
            "White",
            "Blue",
            "Red",
            "Green",
            "Brown",
            "Yellow",
            "Pink",
            "Orange",
            "Gray",
            "Silver"});
            this.ChkBoxColor.Location = new System.Drawing.Point(560, 93);
            this.ChkBoxColor.Name = "ChkBoxColor";
            this.ChkBoxColor.Size = new System.Drawing.Size(120, 202);
            this.ChkBoxColor.TabIndex = 3;
            this.ChkBoxColor.SelectedIndexChanged += new System.EventHandler(this.ChkBoxColor_SelectedIndexChanged);
            // 
            // ChkBoxYear
            // 
            this.ChkBoxYear.FormattingEnabled = true;
            this.ChkBoxYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.ChkBoxYear.Location = new System.Drawing.Point(231, 93);
            this.ChkBoxYear.Name = "ChkBoxYear";
            this.ChkBoxYear.Size = new System.Drawing.Size(90, 148);
            this.ChkBoxYear.TabIndex = 4;
            this.ChkBoxYear.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnContentChanged);
            this.ChkBoxYear.SelectedIndexChanged += new System.EventHandler(this.ChkBoxYear_SelectedIndexChanged);
            // 
            // ChkBoxDoorNumber
            // 
            this.ChkBoxDoorNumber.FormattingEnabled = true;
            this.ChkBoxDoorNumber.Items.AddRange(new object[] {
            "3 Doors (Short)",
            "5 Doors (Long)"});
            this.ChkBoxDoorNumber.Location = new System.Drawing.Point(366, 93);
            this.ChkBoxDoorNumber.Name = "ChkBoxDoorNumber";
            this.ChkBoxDoorNumber.Size = new System.Drawing.Size(120, 40);
            this.ChkBoxDoorNumber.TabIndex = 5;
            this.ChkBoxDoorNumber.SelectedIndexChanged += new System.EventHandler(this.ChkBoxDoorNumber_SelectedIndexChanged);
            // 
            // ChkBoxIsHybrid
            // 
            this.ChkBoxIsHybrid.AutoSize = true;
            this.ChkBoxIsHybrid.Location = new System.Drawing.Point(69, 346);
            this.ChkBoxIsHybrid.Name = "ChkBoxIsHybrid";
            this.ChkBoxIsHybrid.Size = new System.Drawing.Size(103, 19);
            this.ChkBoxIsHybrid.TabIndex = 6;
            this.ChkBoxIsHybrid.Text = "Hybrid Version";
            this.ChkBoxIsHybrid.UseVisualStyleBackColor = true;
            this.ChkBoxIsHybrid.CheckedChanged += new System.EventHandler(this.ChkBoxIsHybrid_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(36, 501);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Total Price: ";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTotalPrice.Location = new System.Drawing.Point(132, 501);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(19, 21);
            this.LblTotalPrice.TabIndex = 8;
            this.LblTotalPrice.Text = "0";
            // 
            // ChkBoxIsMultimedia
            // 
            this.ChkBoxIsMultimedia.AutoSize = true;
            this.ChkBoxIsMultimedia.Location = new System.Drawing.Point(69, 386);
            this.ChkBoxIsMultimedia.Name = "ChkBoxIsMultimedia";
            this.ChkBoxIsMultimedia.Size = new System.Drawing.Size(125, 19);
            this.ChkBoxIsMultimedia.TabIndex = 9;
            this.ChkBoxIsMultimedia.Text = "Multimedia Screen";
            this.ChkBoxIsMultimedia.UseVisualStyleBackColor = true;
            this.ChkBoxIsMultimedia.CheckedChanged += new System.EventHandler(this.ChkBoxIsMultimedia_CheckedChanged);
            // 
            // ChkBoxIsMetallicColor
            // 
            this.ChkBoxIsMetallicColor.AutoSize = true;
            this.ChkBoxIsMetallicColor.Location = new System.Drawing.Point(69, 430);
            this.ChkBoxIsMetallicColor.Name = "ChkBoxIsMetallicColor";
            this.ChkBoxIsMetallicColor.Size = new System.Drawing.Size(100, 19);
            this.ChkBoxIsMetallicColor.TabIndex = 10;
            this.ChkBoxIsMetallicColor.Text = "Metallic Color";
            this.ChkBoxIsMetallicColor.UseVisualStyleBackColor = true;
            this.ChkBoxIsMetallicColor.CheckedChanged += new System.EventHandler(this.ChkBoxIsMetallicColor_CheckedChanged);
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.Location = new System.Drawing.Point(656, 563);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(0, 15);
            this.LblWarning.TabIndex = 11;
            // 
            // OrderPrivateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 592);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.ChkBoxIsMetallicColor);
            this.Controls.Add(this.ChkBoxIsMultimedia);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChkBoxIsHybrid);
            this.Controls.Add(this.ChkBoxDoorNumber);
            this.Controls.Add(this.ChkBoxYear);
            this.Controls.Add(this.ChkBoxColor);
            this.Controls.Add(this.ChkBoxMakeAndModel);
            this.Controls.Add(this.BtnSubmitPrivateCar);
            this.Controls.Add(this.label1);
            this.Name = "OrderPrivateCar";
            this.Text = "OrderPrivateCar";
            this.Load += new System.EventHandler(this.OrderPrivateCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BtnSubmitPrivateCar;
        private CheckedListBox ChkBoxMakeAndModel;
        private CheckedListBox ChkBoxColor;
        private CheckedListBox ChkBoxYear;
        private CheckedListBox ChkBoxDoorNumber;
        private CheckBox ChkBoxIsHybrid;
        private TextBox textBox1;
        private Label LblTotalPrice;
        private CheckBox ChkBoxIsMultimedia;
        private CheckBox ChkBoxIsMetallicColor;
        private Label LblWarning;
    }
}