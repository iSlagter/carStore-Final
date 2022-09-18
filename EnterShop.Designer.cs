namespace carStore_Final
{
    partial class EnterShop
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
            this.BtnEnterStore = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEnterStore
            // 
            this.BtnEnterStore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnEnterStore.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEnterStore.Location = new System.Drawing.Point(189, 452);
            this.BtnEnterStore.Name = "BtnEnterStore";
            this.BtnEnterStore.Size = new System.Drawing.Size(340, 117);
            this.BtnEnterStore.TabIndex = 0;
            this.BtnEnterStore.Text = "Enter To Buy Vehicle";
            this.BtnEnterStore.UseVisualStyleBackColor = false;
            this.BtnEnterStore.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblTitle.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(54, 20);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(638, 67);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Slagter Vehicle Shop";
            this.LblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnterShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::carStore_Final.Properties.Resources.car2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(760, 592);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnEnterStore);
            this.Name = "EnterShop";
            this.Text = "EnterShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnEnterStore;
        private Label LblTitle;
    }
}