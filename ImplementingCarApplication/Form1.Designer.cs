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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCars = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nFeulAmount = new System.Windows.Forms.NumericUpDown();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnRefeul = new System.Windows.Forms.Button();
            this.btnReturnMaintenance = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.lbCarInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFeulAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btnAddCar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCars);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(484, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cars";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(316, 119);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(94, 31);
            this.numericUpDown1.TabIndex = 11;
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCar.Location = new System.Drawing.Point(23, 173);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(187, 49);
            this.btnAddCar.TabIndex = 5;
            this.btnAddCar.Text = "Add car ";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Maximum fuel level: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter License plate:";
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
            this.cbCars.Location = new System.Drawing.Point(23, 307);
            this.cbCars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCars.Name = "cbCars";
            this.cbCars.Size = new System.Drawing.Size(171, 33);
            this.cbCars.TabIndex = 7;
            this.cbCars.Text = "cars";
            this.cbCars.SelectedIndexChanged += new System.EventHandler(this.cbCars_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select a car to get the information ";
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
            this.groupBox2.Location = new System.Drawing.Point(552, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(696, 373);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Chooses";
            // 
            // nFeulAmount
            // 
            this.nFeulAmount.Location = new System.Drawing.Point(341, 142);
            this.nFeulAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nFeulAmount.Name = "nFeulAmount";
            this.nFeulAmount.Size = new System.Drawing.Size(99, 31);
            this.nFeulAmount.TabIndex = 5;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSell.Location = new System.Drawing.Point(341, 217);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(240, 65);
            this.btnSell.TabIndex = 4;
            this.btnSell.Text = "Sell the car ";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnRefeul
            // 
            this.btnRefeul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefeul.Location = new System.Drawing.Point(448, 125);
            this.btnRefeul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefeul.Name = "btnRefeul";
            this.btnRefeul.Size = new System.Drawing.Size(133, 65);
            this.btnRefeul.TabIndex = 3;
            this.btnRefeul.Text = "Refuel a car ";
            this.btnRefeul.UseVisualStyleBackColor = false;
            this.btnRefeul.Click += new System.EventHandler(this.btnRefeul_Click);
            // 
            // btnReturnMaintenance
            // 
            this.btnReturnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReturnMaintenance.Location = new System.Drawing.Point(54, 217);
            this.btnReturnMaintenance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturnMaintenance.Name = "btnReturnMaintenance";
            this.btnReturnMaintenance.Size = new System.Drawing.Size(240, 65);
            this.btnReturnMaintenance.TabIndex = 2;
            this.btnReturnMaintenance.Text = "Return a car from maintenance";
            this.btnReturnMaintenance.UseVisualStyleBackColor = false;
            this.btnReturnMaintenance.Click += new System.EventHandler(this.btnReturnMaintenance_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMaintenance.Location = new System.Drawing.Point(54, 125);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(240, 65);
            this.btnMaintenance.TabIndex = 1;
            this.btnMaintenance.Text = "Send a car to maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // lbCarInfo
            // 
            this.lbCarInfo.AutoSize = true;
            this.lbCarInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCarInfo.Location = new System.Drawing.Point(54, 64);
            this.lbCarInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCarInfo.Name = "lbCarInfo";
            this.lbCarInfo.Size = new System.Drawing.Size(98, 32);
            this.lbCarInfo.TabIndex = 0;
            this.lbCarInfo.Text = "Car Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFeulAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nFeulAmount;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnRefeul;
        private System.Windows.Forms.Button btnReturnMaintenance;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Label lbCarInfo;
        private System.Windows.Forms.ComboBox cbCars;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}
