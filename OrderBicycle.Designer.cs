namespace carStore_Final
{
    partial class OrderBicycle
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
            this.BtnSubmitBicycle = new System.Windows.Forms.Button();
            this.ChkBoxMakeAndModel = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxColor = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxYear = new System.Windows.Forms.CheckedListBox();
            this.ChkBoxIsDiscBreak = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.LblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(263, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Bicycle";
            // 
            // BtnSubmitBicycle
            // 
            this.BtnSubmitBicycle.Location = new System.Drawing.Point(668, 551);
            this.BtnSubmitBicycle.Name = "BtnSubmitBicycle";
            this.BtnSubmitBicycle.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmitBicycle.TabIndex = 1;
            this.BtnSubmitBicycle.Text = "Submit";
            this.BtnSubmitBicycle.UseVisualStyleBackColor = true;
            this.BtnSubmitBicycle.Click += new System.EventHandler(this.BtnSubmitBicycle_Click);
            // 
            // ChkBoxMakeAndModel
            // 
            this.ChkBoxMakeAndModel.FormattingEnabled = true;
            this.ChkBoxMakeAndModel.Items.AddRange(new object[] {
            "Trek, Marlin",
            "Cannondale, SuperSix",
            "Mongoose, Salvo",
            "Mongoose, BMX",
            "Specialized, Levo"});
            this.ChkBoxMakeAndModel.Location = new System.Drawing.Point(46, 92);
            this.ChkBoxMakeAndModel.Name = "ChkBoxMakeAndModel";
            this.ChkBoxMakeAndModel.Size = new System.Drawing.Size(147, 94);
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
            this.ChkBoxColor.Location = new System.Drawing.Point(212, 92);
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
            this.ChkBoxYear.Location = new System.Drawing.Point(379, 92);
            this.ChkBoxYear.Name = "ChkBoxYear";
            this.ChkBoxYear.Size = new System.Drawing.Size(120, 148);
            this.ChkBoxYear.TabIndex = 4;
            this.ChkBoxYear.SelectedIndexChanged += new System.EventHandler(this.ChkBoxYear_SelectedIndexChanged);
            // 
            // ChkBoxIsDiscBreak
            // 
            this.ChkBoxIsDiscBreak.AutoSize = true;
            this.ChkBoxIsDiscBreak.Location = new System.Drawing.Point(58, 338);
            this.ChkBoxIsDiscBreak.Name = "ChkBoxIsDiscBreak";
            this.ChkBoxIsDiscBreak.Size = new System.Drawing.Size(80, 19);
            this.ChkBoxIsDiscBreak.TabIndex = 5;
            this.ChkBoxIsDiscBreak.Text = "Disc Break";
            this.ChkBoxIsDiscBreak.UseVisualStyleBackColor = true;
            this.ChkBoxIsDiscBreak.CheckedChanged += new System.EventHandler(this.ChkBoxIsDiscBreak_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(58, 534);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Total Price: ";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTotalPrice.Location = new System.Drawing.Point(147, 535);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(19, 21);
            this.LblTotalPrice.TabIndex = 7;
            this.LblTotalPrice.Text = "0";
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.Location = new System.Drawing.Point(688, 519);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(0, 15);
            this.LblWarning.TabIndex = 8;
            // 
            // OrderBicycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 592);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChkBoxIsDiscBreak);
            this.Controls.Add(this.ChkBoxYear);
            this.Controls.Add(this.ChkBoxColor);
            this.Controls.Add(this.ChkBoxMakeAndModel);
            this.Controls.Add(this.BtnSubmitBicycle);
            this.Controls.Add(this.label1);
            this.Name = "OrderBicycle";
            this.Text = "OrderBicycle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BtnSubmitBicycle;
        private CheckedListBox ChkBoxMakeAndModel;
        private CheckedListBox ChkBoxColor;
        private CheckedListBox ChkBoxYear;
        private CheckBox ChkBoxIsDiscBreak;
        private TextBox textBox1;
        private Label LblTotalPrice;
        private Label LblWarning;
    }
}