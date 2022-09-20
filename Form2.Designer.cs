namespace carStore_Final
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnOrderJeep = new System.Windows.Forms.Button();
            this.BtnOrderPrivateCar = new System.Windows.Forms.Button();
            this.BtnOrderMotorcycle = new System.Windows.Forms.Button();
            this.BtnOrderBicycle = new System.Windows.Forms.Button();
            this.BtnSaveOrder = new System.Windows.Forms.Button();
            this.BtnLoadOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(305, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "carShop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "carStore JEEP - Big car for big men";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "carStore Private car  - Classic car for classic men";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "carStore Motorcycle  - Dangerous vehicle for Dangerous men";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "carStore Bicycle - Popular Vehicle for Dutch pepole";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtnOrderJeep
            // 
            this.BtnOrderJeep.Location = new System.Drawing.Point(626, 105);
            this.BtnOrderJeep.Name = "BtnOrderJeep";
            this.BtnOrderJeep.Size = new System.Drawing.Size(125, 25);
            this.BtnOrderJeep.TabIndex = 5;
            this.BtnOrderJeep.Text = "Order Jeep";
            this.BtnOrderJeep.UseVisualStyleBackColor = true;
            this.BtnOrderJeep.Click += new System.EventHandler(this.BtnOrderJeep_Click);
            // 
            // BtnOrderPrivateCar
            // 
            this.BtnOrderPrivateCar.Location = new System.Drawing.Point(628, 148);
            this.BtnOrderPrivateCar.Name = "BtnOrderPrivateCar";
            this.BtnOrderPrivateCar.Size = new System.Drawing.Size(125, 25);
            this.BtnOrderPrivateCar.TabIndex = 6;
            this.BtnOrderPrivateCar.Text = "Order Private Car";
            this.BtnOrderPrivateCar.UseVisualStyleBackColor = true;
            this.BtnOrderPrivateCar.Click += new System.EventHandler(this.BtnOrderPrivateCar_Click);
            // 
            // BtnOrderMotorcycle
            // 
            this.BtnOrderMotorcycle.Location = new System.Drawing.Point(628, 192);
            this.BtnOrderMotorcycle.Name = "BtnOrderMotorcycle";
            this.BtnOrderMotorcycle.Size = new System.Drawing.Size(125, 25);
            this.BtnOrderMotorcycle.TabIndex = 7;
            this.BtnOrderMotorcycle.Text = "Order Motorcycle";
            this.BtnOrderMotorcycle.UseVisualStyleBackColor = true;
            this.BtnOrderMotorcycle.Click += new System.EventHandler(this.BtnOrderMotorcycle_Click);
            // 
            // BtnOrderBicycle
            // 
            this.BtnOrderBicycle.Location = new System.Drawing.Point(628, 236);
            this.BtnOrderBicycle.Name = "BtnOrderBicycle";
            this.BtnOrderBicycle.Size = new System.Drawing.Size(125, 25);
            this.BtnOrderBicycle.TabIndex = 8;
            this.BtnOrderBicycle.Text = "Order Bicycle";
            this.BtnOrderBicycle.UseVisualStyleBackColor = true;
            this.BtnOrderBicycle.Click += new System.EventHandler(this.BtnOrderBicycle_Click);
            // 
            // BtnSaveOrder
            // 
            this.BtnSaveOrder.Location = new System.Drawing.Point(161, 551);
            this.BtnSaveOrder.Name = "BtnSaveOrder";
            this.BtnSaveOrder.Size = new System.Drawing.Size(125, 25);
            this.BtnSaveOrder.TabIndex = 9;
            this.BtnSaveOrder.Text = "Save Order";
            this.BtnSaveOrder.UseVisualStyleBackColor = true;
            this.BtnSaveOrder.Click += new System.EventHandler(this.BtnSaveOrder_Click);
            // 
            // BtnLoadOrder
            // 
            this.BtnLoadOrder.Location = new System.Drawing.Point(17, 551);
            this.BtnLoadOrder.Name = "BtnLoadOrder";
            this.BtnLoadOrder.Size = new System.Drawing.Size(125, 25);
            this.BtnLoadOrder.TabIndex = 10;
            this.BtnLoadOrder.Text = "Load Order";
            this.BtnLoadOrder.UseVisualStyleBackColor = true;
            this.BtnLoadOrder.Click += new System.EventHandler(this.BtnLoadOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(503, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Price:";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalPrice.Location = new System.Drawing.Point(652, 552);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(24, 27);
            this.LblTotalPrice.TabIndex = 12;
            this.LblTotalPrice.Text = "0";
            this.LblTotalPrice.Click += new System.EventHandler(this.LblTotalPrice_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(5, 270);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(750, 265);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(17, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 26);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Vehicle";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(689, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(59, 26);
            this.textBox3.TabIndex = 15;
            this.textBox3.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(11, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(737, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 592);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnLoadOrder);
            this.Controls.Add(this.BtnSaveOrder);
            this.Controls.Add(this.BtnOrderBicycle);
            this.Controls.Add(this.BtnOrderMotorcycle);
            this.Controls.Add(this.BtnOrderPrivateCar);
            this.Controls.Add(this.BtnOrderJeep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button BtnOrderJeep;
        private Button BtnOrderPrivateCar;
        private Button BtnOrderMotorcycle;
        private Button BtnOrderBicycle;
        private Button BtnSaveOrder;
        private Button BtnLoadOrder;
        private Label label6;
        private Label LblTotalPrice;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label8;
    }
}