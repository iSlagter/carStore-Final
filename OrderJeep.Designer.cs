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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.BtnSubmitJeep = new System.Windows.Forms.Button();
            this.Btn4x4 = new System.Windows.Forms.RadioButton();
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
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Toyota",
            "Mitsubishi ",
            "Jeep",
            "Land Rover"});
            this.checkedListBox1.Location = new System.Drawing.Point(31, 175);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(147, 76);
            this.checkedListBox1.TabIndex = 1;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.checkedListBox2.Location = new System.Drawing.Point(382, 175);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 148);
            this.checkedListBox2.TabIndex = 2;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Land Crusier",
            "Rav4",
            "Pajero",
            "Outlander",
            "Grand Cherokie",
            "Wrengler",
            "RangeRover"});
            this.checkedListBox3.Location = new System.Drawing.Point(218, 175);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(120, 130);
            this.checkedListBox3.TabIndex = 3;
            // 
            // BtnSubmitJeep
            // 
            this.BtnSubmitJeep.Location = new System.Drawing.Point(656, 533);
            this.BtnSubmitJeep.Name = "BtnSubmitJeep";
            this.BtnSubmitJeep.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmitJeep.TabIndex = 4;
            this.BtnSubmitJeep.Text = "Submit";
            this.BtnSubmitJeep.UseVisualStyleBackColor = true;
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
            // 
            // OrderJeep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 592);
            this.Controls.Add(this.Btn4x4);
            this.Controls.Add(this.BtnSubmitJeep);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "OrderJeep";
            this.Text = "OrderJeep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private CheckedListBox checkedListBox3;
        private Button BtnSubmitJeep;
        private RadioButton Btn4x4;
    }
}