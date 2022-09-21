namespace carStore_Final
{
    partial class OrderJeep
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
            this.ChkBoxMakeAndModel = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxYear = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxColor = new System.Windows.Forms.CheckedListBox();
            this.BtnSubmitJeep = new System.Windows.Forms.Button();
            this.ChkBoxDoorNumber = new System.Windows.Forms.CheckedListBox();
            this.TotalPriceTxt = new System.Windows.Forms.TextBox();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.ChkBoxIs4x4 = new System.Windows.Forms.CheckBox();
            this.ChkBoxIsMetallicColor = new System.Windows.Forms.CheckBox();
            this.ChkBoxIsMultimedia = new System.Windows.Forms.CheckBox();
            this.LblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order JEEP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChkBoxMakeAndModel
            // 
            this.ChkBoxMakeAndModel.FormattingEnabled = true;
            this.ChkBoxMakeAndModel.Items.AddRange(new object[] {
            "Toyota, Land Crusier",
            "Toyota, Rav4",
            "Mitsubishi, Pajero",
            "Mitsubishi, Outlander",
            "Jeep,Grand Cherokie",
            "Jeep, Wrengler ",
            "Land Rover, Range Rover"});
            this.ChkBoxMakeAndModel.Location = new System.Drawing.Point(40, 98);
            this.ChkBoxMakeAndModel.Name = "ChkBoxMakeAndModel";
            this.ChkBoxMakeAndModel.Size = new System.Drawing.Size(198, 130);
            this.ChkBoxMakeAndModel.TabIndex = 1;
            this.ChkBoxMakeAndModel.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
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
            this.ChkBoxYear.Location = new System.Drawing.Point(268, 98);
            this.ChkBoxYear.Name = "ChkBoxYear";
            this.ChkBoxYear.Size = new System.Drawing.Size(120, 148);
            this.ChkBoxYear.TabIndex = 2;
            this.ChkBoxYear.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnContentChanged);
            this.ChkBoxYear.SelectedIndexChanged += new System.EventHandler(this.ChkBoxYear_SelectedIndexChanged);
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
            this.ChkBoxColor.Location = new System.Drawing.Point(583, 98);
            this.ChkBoxColor.Name = "ChkBoxColor";
            this.ChkBoxColor.Size = new System.Drawing.Size(120, 202);
            this.ChkBoxColor.TabIndex = 3;
            this.ChkBoxColor.SelectedIndexChanged += new System.EventHandler(this.ChkBoxColor_SelectedIndexChanged);
            // 
            // BtnSubmitJeep
            // 
            this.BtnSubmitJeep.Location = new System.Drawing.Point(656, 533);
            this.BtnSubmitJeep.Name = "BtnSubmitJeep";
            this.BtnSubmitJeep.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmitJeep.TabIndex = 4;
            this.BtnSubmitJeep.Text = "Submit";
            this.BtnSubmitJeep.UseVisualStyleBackColor = true;
            this.BtnSubmitJeep.Click += new System.EventHandler(this.BtnSubmitJeep_Click);
            // 
            // ChkBoxDoorNumber
            // 
            this.ChkBoxDoorNumber.FormattingEnabled = true;
            this.ChkBoxDoorNumber.Items.AddRange(new object[] {
            "3 Doors (Short)",
            "5 Doors (Long)"});
            this.ChkBoxDoorNumber.Location = new System.Drawing.Point(415, 98);
            this.ChkBoxDoorNumber.Name = "ChkBoxDoorNumber";
            this.ChkBoxDoorNumber.Size = new System.Drawing.Size(120, 40);
            this.ChkBoxDoorNumber.TabIndex = 7;
            this.ChkBoxDoorNumber.SelectedIndexChanged += new System.EventHandler(this.ChkBoxDoorNumber_SelectedIndexChanged);
            // 
            // TotalPriceTxt
            // 
            this.TotalPriceTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalPriceTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPriceTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceTxt.Location = new System.Drawing.Point(15, 532);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.Size = new System.Drawing.Size(100, 22);
            this.TotalPriceTxt.TabIndex = 9;
            this.TotalPriceTxt.Text = "Total Price: ";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTotalPrice.Location = new System.Drawing.Point(106, 533);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(19, 21);
            this.LblTotalPrice.TabIndex = 10;
            this.LblTotalPrice.Text = "0";
            this.LblTotalPrice.Click += new System.EventHandler(this.LblTotalPrice_Click);
            // 
            // ChkBoxIs4x4
            // 
            this.ChkBoxIs4x4.AutoSize = true;
            this.ChkBoxIs4x4.Location = new System.Drawing.Point(40, 268);
            this.ChkBoxIs4x4.Name = "ChkBoxIs4x4";
            this.ChkBoxIs4x4.Size = new System.Drawing.Size(85, 19);
            this.ChkBoxIs4x4.TabIndex = 11;
            this.ChkBoxIs4x4.Text = "4x4 Version";
            this.ChkBoxIs4x4.UseVisualStyleBackColor = true;
            this.ChkBoxIs4x4.CheckedChanged += new System.EventHandler(this.OnContentChanged);
            // 
            // ChkBoxIsMetallicColor
            // 
            this.ChkBoxIsMetallicColor.AutoSize = true;
            this.ChkBoxIsMetallicColor.Location = new System.Drawing.Point(40, 298);
            this.ChkBoxIsMetallicColor.Name = "ChkBoxIsMetallicColor";
            this.ChkBoxIsMetallicColor.Size = new System.Drawing.Size(100, 19);
            this.ChkBoxIsMetallicColor.TabIndex = 14;
            this.ChkBoxIsMetallicColor.Text = "Metallic Color";
            this.ChkBoxIsMetallicColor.UseVisualStyleBackColor = true;
            this.ChkBoxIsMetallicColor.CheckedChanged += new System.EventHandler(this.OnContentChanged);
            // 
            // ChkBoxIsMultimedia
            // 
            this.ChkBoxIsMultimedia.AutoSize = true;
            this.ChkBoxIsMultimedia.Location = new System.Drawing.Point(40, 331);
            this.ChkBoxIsMultimedia.Name = "ChkBoxIsMultimedia";
            this.ChkBoxIsMultimedia.Size = new System.Drawing.Size(125, 19);
            this.ChkBoxIsMultimedia.TabIndex = 15;
            this.ChkBoxIsMultimedia.Text = "Multimedia Screen";
            this.ChkBoxIsMultimedia.UseVisualStyleBackColor = true;
            this.ChkBoxIsMultimedia.CheckedChanged += new System.EventHandler(this.ChkBoxIsMultimedia_CheckedChanged);
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.Location = new System.Drawing.Point(656, 563);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(0, 15);
            this.LblWarning.TabIndex = 16;
            // 
            // OrderJeep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 592);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.ChkBoxIsMultimedia);
            this.Controls.Add(this.ChkBoxIsMetallicColor);
            this.Controls.Add(this.ChkBoxIs4x4);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.TotalPriceTxt);
            this.Controls.Add(this.ChkBoxDoorNumber);
            this.Controls.Add(this.BtnSubmitJeep);
            this.Controls.Add(this.ChkBoxColor);
            this.Controls.Add(this.ChkBoxYear);
            this.Controls.Add(this.ChkBoxMakeAndModel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "OrderJeep";
            this.Text = "OrderJeep";
            this.Load += new System.EventHandler(this.OrderJeep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckedListBox ChkBoxMakeAndModel;
        private CheckedListBox ChkBoxYear;
        private CheckedListBox ChkBoxColor;
        private Button BtnSubmitJeep;
        private CheckedListBox ChkBoxDoorNumber;
        private TextBox TotalPriceTxt;
        private Label LblTotalPrice;
        private CheckBox ChkBoxIs4x4;
        private CheckBox ChkBoxIsMetallicColor;
        private CheckBox ChkBoxIsMultimedia;
        private Label LblWarning;
    }
}