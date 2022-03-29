namespace FinalProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.rbCar = new System.Windows.Forms.RadioButton();
            this.rbSuv = new System.Windows.Forms.RadioButton();
            this.rbMotorcycle = new System.Windows.Forms.RadioButton();
            this.btnDrive = new System.Windows.Forms.Button();
            this.lblMiles = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblBrakes = new System.Windows.Forms.Label();
            this.lblOil = new System.Windows.Forms.Label();
            this.lblTires = new System.Windows.Forms.Label();
            this.lblDiagnostics = new System.Windows.Forms.Label();
            this.btnFuel = new System.Windows.Forms.Button();
            this.btnBrakes = new System.Windows.Forms.Button();
            this.btnOil = new System.Windows.Forms.Button();
            this.btnTires = new System.Windows.Forms.Button();
            this.btnDiagnostics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fundsLabel = new System.Windows.Forms.Label();
            this.messagesHeaderLabel = new System.Windows.Forms.Label();
            this.messagesLabel = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(229, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(414, 42);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // rbCar
            // 
            this.rbCar.AutoSize = true;
            this.rbCar.Location = new System.Drawing.Point(62, 128);
            this.rbCar.Margin = new System.Windows.Forms.Padding(2);
            this.rbCar.Name = "rbCar";
            this.rbCar.Size = new System.Drawing.Size(41, 17);
            this.rbCar.TabIndex = 3;
            this.rbCar.TabStop = true;
            this.rbCar.Text = "Car";
            this.rbCar.UseVisualStyleBackColor = true;
            this.rbCar.CheckedChanged += new System.EventHandler(this.rbCar_CheckedChanged);
            // 
            // rbSuv
            // 
            this.rbSuv.AutoSize = true;
            this.rbSuv.Location = new System.Drawing.Point(244, 128);
            this.rbSuv.Margin = new System.Windows.Forms.Padding(2);
            this.rbSuv.Name = "rbSuv";
            this.rbSuv.Size = new System.Drawing.Size(47, 17);
            this.rbSuv.TabIndex = 4;
            this.rbSuv.TabStop = true;
            this.rbSuv.Text = "SUV";
            this.rbSuv.UseVisualStyleBackColor = true;
            this.rbSuv.CheckedChanged += new System.EventHandler(this.rbSuv_CheckedChanged);
            // 
            // rbMotorcycle
            // 
            this.rbMotorcycle.AutoSize = true;
            this.rbMotorcycle.Location = new System.Drawing.Point(416, 128);
            this.rbMotorcycle.Margin = new System.Windows.Forms.Padding(2);
            this.rbMotorcycle.Name = "rbMotorcycle";
            this.rbMotorcycle.Size = new System.Drawing.Size(77, 17);
            this.rbMotorcycle.TabIndex = 5;
            this.rbMotorcycle.TabStop = true;
            this.rbMotorcycle.Text = "Motorcycle";
            this.rbMotorcycle.UseVisualStyleBackColor = true;
            this.rbMotorcycle.CheckedChanged += new System.EventHandler(this.rbMotorcycle_CheckedChanged);
            // 
            // btnDrive
            // 
            this.btnDrive.Location = new System.Drawing.Point(414, 225);
            this.btnDrive.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrive.Name = "btnDrive";
            this.btnDrive.Size = new System.Drawing.Size(56, 19);
            this.btnDrive.TabIndex = 6;
            this.btnDrive.Text = "Drive";
            this.btnDrive.UseVisualStyleBackColor = true;
            this.btnDrive.Click += new System.EventHandler(this.btnDrive_Click);
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(248, 225);
            this.lblMiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(34, 13);
            this.lblMiles.TabIndex = 7;
            this.lblMiles.Text = "Miles:";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(310, 225);
            this.txtMiles.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(76, 20);
            this.txtMiles.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(203, 286);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(203, 411);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 75);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(361, 411);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 75);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(361, 286);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 75);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(475, 350);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(75, 75);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(205, 270);
            this.lblFuel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(27, 13);
            this.lblFuel.TabIndex = 14;
            this.lblFuel.Text = "Fuel";
            this.lblFuel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBrakes
            // 
            this.lblBrakes.AutoSize = true;
            this.lblBrakes.Location = new System.Drawing.Point(201, 394);
            this.lblBrakes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrakes.Name = "lblBrakes";
            this.lblBrakes.Size = new System.Drawing.Size(40, 13);
            this.lblBrakes.TabIndex = 15;
            this.lblBrakes.Text = "Brakes";
            this.lblBrakes.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOil
            // 
            this.lblOil.AutoSize = true;
            this.lblOil.Location = new System.Drawing.Point(359, 270);
            this.lblOil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOil.Name = "lblOil";
            this.lblOil.Size = new System.Drawing.Size(19, 13);
            this.lblOil.TabIndex = 16;
            this.lblOil.Text = "Oil";
            this.lblOil.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTires
            // 
            this.lblTires.AutoSize = true;
            this.lblTires.Location = new System.Drawing.Point(361, 394);
            this.lblTires.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTires.Name = "lblTires";
            this.lblTires.Size = new System.Drawing.Size(30, 13);
            this.lblTires.TabIndex = 17;
            this.lblTires.Text = "Tires";
            this.lblTires.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDiagnostics
            // 
            this.lblDiagnostics.AutoSize = true;
            this.lblDiagnostics.Location = new System.Drawing.Point(473, 333);
            this.lblDiagnostics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiagnostics.Name = "lblDiagnostics";
            this.lblDiagnostics.Size = new System.Drawing.Size(62, 13);
            this.lblDiagnostics.TabIndex = 18;
            this.lblDiagnostics.Text = "Diagnostics";
            this.lblDiagnostics.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnFuel
            // 
            this.btnFuel.Location = new System.Drawing.Point(203, 361);
            this.btnFuel.Margin = new System.Windows.Forms.Padding(2);
            this.btnFuel.Name = "btnFuel";
            this.btnFuel.Size = new System.Drawing.Size(56, 19);
            this.btnFuel.TabIndex = 19;
            this.btnFuel.Text = "Add";
            this.btnFuel.UseVisualStyleBackColor = true;
            this.btnFuel.Click += new System.EventHandler(this.btnFuel_Click);
            // 
            // btnBrakes
            // 
            this.btnBrakes.Location = new System.Drawing.Point(203, 486);
            this.btnBrakes.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrakes.Name = "btnBrakes";
            this.btnBrakes.Size = new System.Drawing.Size(56, 19);
            this.btnBrakes.TabIndex = 20;
            this.btnBrakes.Text = "Replace";
            this.btnBrakes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrakes.UseVisualStyleBackColor = true;
            this.btnBrakes.Click += new System.EventHandler(this.btnBrakes_Click);
            // 
            // btnOil
            // 
            this.btnOil.Location = new System.Drawing.Point(361, 361);
            this.btnOil.Margin = new System.Windows.Forms.Padding(2);
            this.btnOil.Name = "btnOil";
            this.btnOil.Size = new System.Drawing.Size(56, 19);
            this.btnOil.TabIndex = 21;
            this.btnOil.Text = "Change";
            this.btnOil.UseVisualStyleBackColor = true;
            this.btnOil.Click += new System.EventHandler(this.btnOil_Click);
            // 
            // btnTires
            // 
            this.btnTires.Location = new System.Drawing.Point(361, 486);
            this.btnTires.Margin = new System.Windows.Forms.Padding(2);
            this.btnTires.Name = "btnTires";
            this.btnTires.Size = new System.Drawing.Size(56, 19);
            this.btnTires.TabIndex = 22;
            this.btnTires.Text = "Replace";
            this.btnTires.UseVisualStyleBackColor = true;
            this.btnTires.Click += new System.EventHandler(this.btnTires_Click);
            // 
            // btnDiagnostics
            // 
            this.btnDiagnostics.Location = new System.Drawing.Point(475, 425);
            this.btnDiagnostics.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiagnostics.Name = "btnDiagnostics";
            this.btnDiagnostics.Size = new System.Drawing.Size(56, 19);
            this.btnDiagnostics.TabIndex = 23;
            this.btnDiagnostics.Text = "Run";
            this.btnDiagnostics.UseVisualStyleBackColor = true;
            this.btnDiagnostics.Click += new System.EventHandler(this.btnDiagnostics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select a vehicle";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(208, 166);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(142, 23);
            this.btnPurchase.TabIndex = 25;
            this.btnPurchase.Text = "Purchase Vehicle";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Your Funds:  ";
            // 
            // fundsLabel
            // 
            this.fundsLabel.AutoSize = true;
            this.fundsLabel.Location = new System.Drawing.Point(98, 171);
            this.fundsLabel.Name = "fundsLabel";
            this.fundsLabel.Size = new System.Drawing.Size(35, 13);
            this.fundsLabel.TabIndex = 27;
            this.fundsLabel.Text = "label3";
            // 
            // messagesHeaderLabel
            // 
            this.messagesHeaderLabel.AutoSize = true;
            this.messagesHeaderLabel.Location = new System.Drawing.Point(12, 206);
            this.messagesHeaderLabel.Name = "messagesHeaderLabel";
            this.messagesHeaderLabel.Size = new System.Drawing.Size(61, 13);
            this.messagesHeaderLabel.TabIndex = 28;
            this.messagesHeaderLabel.Text = "Messages: ";
            // 
            // messagesLabel
            // 
            this.messagesLabel.AutoSize = true;
            this.messagesLabel.Location = new System.Drawing.Point(13, 233);
            this.messagesLabel.Name = "messagesLabel";
            this.messagesLabel.Size = new System.Drawing.Size(0, 13);
            this.messagesLabel.TabIndex = 29;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(232, 8);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset All";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 515);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.messagesLabel);
            this.Controls.Add(this.messagesHeaderLabel);
            this.Controls.Add(this.fundsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiagnostics);
            this.Controls.Add(this.btnTires);
            this.Controls.Add(this.btnOil);
            this.Controls.Add(this.btnBrakes);
            this.Controls.Add(this.btnFuel);
            this.Controls.Add(this.lblDiagnostics);
            this.Controls.Add(this.lblTires);
            this.Controls.Add(this.lblOil);
            this.Controls.Add(this.lblBrakes);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.btnDrive);
            this.Controls.Add(this.rbMotorcycle);
            this.Controls.Add(this.rbSuv);
            this.Controls.Add(this.rbCar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton rbCar;
        private System.Windows.Forms.RadioButton rbSuv;
        private System.Windows.Forms.RadioButton rbMotorcycle;
        private System.Windows.Forms.Button btnDrive;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblBrakes;
        private System.Windows.Forms.Label lblOil;
        private System.Windows.Forms.Label lblTires;
        private System.Windows.Forms.Label lblDiagnostics;
        private System.Windows.Forms.Button btnFuel;
        private System.Windows.Forms.Button btnBrakes;
        private System.Windows.Forms.Button btnOil;
        private System.Windows.Forms.Button btnTires;
        private System.Windows.Forms.Button btnDiagnostics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fundsLabel;
        private System.Windows.Forms.Label messagesHeaderLabel;
        private System.Windows.Forms.Label messagesLabel;
        private System.Windows.Forms.Button btnReset;
    }
}

