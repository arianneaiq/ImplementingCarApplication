namespace ImplementingCarApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCars = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowCar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nFeulAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnRefeul = new System.Windows.Forms.Button();
            this.btnReturnMaintenance = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.lbCarInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFeulAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.cbCars);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cars";
            // 
            // cbCars
            // 
            this.cbCars.FormattingEnabled = true;
            this.cbCars.Items.AddRange(new object[] {
            "Ferrari",
            "Toyota",
            "Bucati",
            "Lamborgini",
            "kawasaki"});
            this.cbCars.Location = new System.Drawing.Point(16, 75);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(121, 23);
            this.cbCars.TabIndex = 7;
            this.cbCars.SelectedIndexChanged += new System.EventHandler(this.cbCars_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a car to get the information ";
            // 
            // btnShowCar
            // 
            this.btnShowCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowCar.Location = new System.Drawing.Point(26, 37);
            this.btnShowCar.Name = "btnShowCar";
            this.btnShowCar.Size = new System.Drawing.Size(339, 39);
            this.btnShowCar.TabIndex = 5;
            this.btnShowCar.Text = "Show Car";
            this.btnShowCar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.nFeulAmount);
            this.groupBox2.Controls.Add(this.btnSell);
            this.groupBox2.Controls.Add(this.btnRefeul);
            this.groupBox2.Controls.Add(this.btnReturnMaintenance);
            this.groupBox2.Controls.Add(this.btnMaintenance);
            this.groupBox2.Controls.Add(this.lbCarInfo);
            this.groupBox2.Location = new System.Drawing.Point(388, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 213);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Chooses";
            // 
            // nFeulAmount
            // 
            this.nFeulAmount.Location = new System.Drawing.Point(207, 85);
            this.nFeulAmount.Name = "nFeulAmount";
            this.nFeulAmount.Size = new System.Drawing.Size(69, 23);
            this.nFeulAmount.TabIndex = 5;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSell.Location = new System.Drawing.Point(207, 130);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(168, 39);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "Sell the car ";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnRefeul
            // 
            this.btnRefeul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefeul.Location = new System.Drawing.Point(282, 75);
            this.btnRefeul.Name = "btnRefeul";
            this.btnRefeul.Size = new System.Drawing.Size(93, 39);
            this.btnRefeul.TabIndex = 3;
            this.btnRefeul.Text = "Refuel a car ";
            this.btnRefeul.UseVisualStyleBackColor = false;
            this.btnRefeul.Click += new System.EventHandler(this.btnRefeul_Click);
            // 
            // btnReturnMaintenance
            // 
            this.btnReturnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturnMaintenance.Location = new System.Drawing.Point(6, 130);
            this.btnReturnMaintenance.Name = "btnReturnMaintenance";
            this.btnReturnMaintenance.Size = new System.Drawing.Size(168, 39);
            this.btnReturnMaintenance.TabIndex = 2;
            this.btnReturnMaintenance.Text = "Return a car from maintenance";
            this.btnReturnMaintenance.UseVisualStyleBackColor = false;
            this.btnReturnMaintenance.Click += new System.EventHandler(this.btnReturnMaintenance_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMaintenance.Location = new System.Drawing.Point(6, 75);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(168, 39);
            this.btnMaintenance.TabIndex = 1;
            this.btnMaintenance.Text = "Send a car to maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // lbCarInfo
            // 
            this.lbCarInfo.AutoSize = true;
            this.lbCarInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCarInfo.Location = new System.Drawing.Point(6, 38);
            this.lbCarInfo.Name = "lbCarInfo";
            this.lbCarInfo.Size = new System.Drawing.Size(65, 21);
            this.lbCarInfo.TabIndex = 0;
            this.lbCarInfo.Text = "Car Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnShowCar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFeulAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowCar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nFeulAmount;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnRefeul;
        private System.Windows.Forms.Button btnReturnMaintenance;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Label lbCarInfo;
        private System.Windows.Forms.ComboBox cbCars;
    }
}
