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
            this.Btn4x4 = new System.Windows.Forms.RadioButton();
            this.BtnMetallicColor = new System.Windows.Forms.RadioButton();
            this.ChkBoxDoorNumber = new System.Windows.Forms.CheckedListBox();
            this.BtnIsMultimedia = new System.Windows.Forms.RadioButton();
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
            this.ChkBoxMakeAndModel.Location = new System.Drawing.Point(31, 175);
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
            this.ChkBoxYear.Location = new System.Drawing.Point(289, 175);
            this.ChkBoxYear.Name = "ChkBoxYear";
            this.ChkBoxYear.Size = new System.Drawing.Size(120, 148);
            this.ChkBoxYear.TabIndex = 2;
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
            this.ChkBoxColor.Location = new System.Drawing.Point(585, 175);
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
            // Btn4x4
            // 
            this.Btn4x4.AutoSize = true;
            this.Btn4x4.Location = new System.Drawing.Point(50, 369);
            this.Btn4x4.Name = "Btn4x4";
            this.Btn4x4.Size = new System.Drawing.Size(88, 19);
            this.Btn4x4.TabIndex = 5;
            this.Btn4x4.TabStop = true;
            this.Btn4x4.Text = "4X4 version ";
            this.Btn4x4.UseVisualStyleBackColor = true;
            this.Btn4x4.CheckedChanged += new System.EventHandler(this.Btn4x4_CheckedChanged);
            // 
            // BtnMetallicColor
            // 
            this.BtnMetallicColor.AutoSize = true;
            this.BtnMetallicColor.Location = new System.Drawing.Point(50, 400);
            this.BtnMetallicColor.Name = "BtnMetallicColor";
            this.BtnMetallicColor.Size = new System.Drawing.Size(99, 19);
            this.BtnMetallicColor.TabIndex = 6;
            this.BtnMetallicColor.TabStop = true;
            this.BtnMetallicColor.Text = "Metallic Color";
            this.BtnMetallicColor.UseVisualStyleBackColor = true;
            this.BtnMetallicColor.CheckedChanged += new System.EventHandler(this.BtnMetallicColor_CheckedChanged);
            // 
            // ChkBoxDoorNumber
            // 
            this.ChkBoxDoorNumber.FormattingEnabled = true;
            this.ChkBoxDoorNumber.Items.AddRange(new object[] {
            "3 Doors (Short)",
            "5 Doors (Long)"});
            this.ChkBoxDoorNumber.Location = new System.Drawing.Point(440, 175);
            this.ChkBoxDoorNumber.Name = "ChkBoxDoorNumber";
            this.ChkBoxDoorNumber.Size = new System.Drawing.Size(120, 40);
            this.ChkBoxDoorNumber.TabIndex = 7;
            this.ChkBoxDoorNumber.SelectedIndexChanged += new System.EventHandler(this.ChkBoxDoorNumber_SelectedIndexChanged);
            // 
            // BtnIsMultimedia
            // 
            this.BtnIsMultimedia.AutoSize = true;
            this.BtnIsMultimedia.Location = new System.Drawing.Point(52, 433);
            this.BtnIsMultimedia.Name = "BtnIsMultimedia";
            this.BtnIsMultimedia.Size = new System.Drawing.Size(124, 19);
            this.BtnIsMultimedia.TabIndex = 8;
            this.BtnIsMultimedia.TabStop = true;
            this.BtnIsMultimedia.Text = "Multimedia Screen";
            this.BtnIsMultimedia.UseVisualStyleBackColor = true;
            // 
            // OrderJeep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 592);
            this.Controls.Add(this.BtnIsMultimedia);
            this.Controls.Add(this.ChkBoxDoorNumber);
            this.Controls.Add(this.BtnMetallicColor);
            this.Controls.Add(this.Btn4x4);
            this.Controls.Add(this.BtnSubmitJeep);
            this.Controls.Add(this.ChkBoxColor);
            this.Controls.Add(this.ChkBoxYear);
            this.Controls.Add(this.ChkBoxMakeAndModel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "OrderJeep";
            this.Text = "OrderJeep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckedListBox ChkBoxMakeAndModel;
        private CheckedListBox ChkBoxYear;
        private CheckedListBox ChkBoxColor;
        private Button BtnSubmitJeep;
        private RadioButton Btn4x4;
        private RadioButton BtnMetallicColor;
        private CheckedListBox ChkBoxDoorNumber;
        private RadioButton BtnIsMultimedia;
    }
}