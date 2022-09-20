namespace carStore_Final
{
    partial class OrderMotorcycle
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
            this.BtnSubmitMotorcycle = new System.Windows.Forms.Button();
            this.ChkBoxMakeAndModel = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxColor = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxYear = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(239, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Motorcycle";
            // 
            // BtnSubmitMotorcycle
            // 
            this.BtnSubmitMotorcycle.Location = new System.Drawing.Point(648, 543);
            this.BtnSubmitMotorcycle.Name = "BtnSubmitMotorcycle";
            this.BtnSubmitMotorcycle.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmitMotorcycle.TabIndex = 1;
            this.BtnSubmitMotorcycle.Text = "Submit";
            this.BtnSubmitMotorcycle.UseVisualStyleBackColor = true;
            this.BtnSubmitMotorcycle.Click += new System.EventHandler(this.BtnSubmitMotorcycle_Click);
            // 
            // ChkBoxMakeAndModel
            // 
            this.ChkBoxMakeAndModel.FormattingEnabled = true;
            this.ChkBoxMakeAndModel.Items.AddRange(new object[] {
            "Ducati, Monster",
            "Honda, CB",
            "KTM, Duke",
            "BMW, F650GS",
            "Sanyang, Joymax",
            "Yamaha, Tmax"});
            this.ChkBoxMakeAndModel.Location = new System.Drawing.Point(68, 163);
            this.ChkBoxMakeAndModel.Name = "ChkBoxMakeAndModel";
            this.ChkBoxMakeAndModel.Size = new System.Drawing.Size(125, 112);
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
            this.ChkBoxColor.Location = new System.Drawing.Point(239, 163);
            this.ChkBoxColor.Name = "ChkBoxColor";
            this.ChkBoxColor.Size = new System.Drawing.Size(120, 202);
            this.ChkBoxColor.TabIndex = 3;
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
            this.ChkBoxYear.Location = new System.Drawing.Point(412, 163);
            this.ChkBoxYear.Name = "ChkBoxYear";
            this.ChkBoxYear.Size = new System.Drawing.Size(120, 148);
            this.ChkBoxYear.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(57, 528);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Total Price: ";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTotalPrice.Location = new System.Drawing.Point(154, 529);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(19, 21);
            this.LblTotalPrice.TabIndex = 6;
            this.LblTotalPrice.Text = "0";
            // 
            // OrderMotorcycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 592);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChkBoxYear);
            this.Controls.Add(this.ChkBoxColor);
            this.Controls.Add(this.ChkBoxMakeAndModel);
            this.Controls.Add(this.BtnSubmitMotorcycle);
            this.Controls.Add(this.label1);
            this.Name = "OrderMotorcycle";
            this.Text = "OrderMotorcycle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BtnSubmitMotorcycle;
        private CheckedListBox ChkBoxMakeAndModel;
        private CheckedListBox ChkBoxColor;
        private CheckedListBox ChkBoxYear;
        private TextBox textBox1;
        private Label LblTotalPrice;
    }
}