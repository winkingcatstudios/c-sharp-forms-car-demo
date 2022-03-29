using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        // Internal variables
        bool purchased = false;
        double funds = 50000.00;
        Vehicle myVehicle = new Car(); // Default vehicles, changes after purchase
        
        // Hides maintainance buttons until vehicle purchase, displays purchase buttons
        private void hideButtons()
        {
            btnFuel.Visible = false;
            btnOil.Visible = false;
            btnBrakes.Visible = false;
            btnTires.Visible = false;
            btnDiagnostics.Visible = false;
            btnReset.Visible = false;
            btnDrive.Visible = false;
            btnPurchase.Visible = true;
            rbCar.Visible = true;
            rbSuv.Visible = true;
            rbMotorcycle.Visible = true;
        }

        // Displays maintainance buttons once vehicle is purchased, hides purchase button
        private void displayButtons()
        {
            btnFuel.Visible = true;
            btnOil.Visible = true;
            btnBrakes.Visible = true;
            btnTires.Visible = true;
            btnDiagnostics.Visible = true;
            btnReset.Visible = true;
            btnDrive.Visible = true;
            btnPurchase.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
            fundsLabel.Text = funds.ToString("C");
            hideButtons();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        // Use polymorphism to drive different vehicle child classes
        private void btnDrive_Click(object sender, EventArgs e)
        {
            // Check for number input
            double outParse;
            if(!Double.TryParse(txtMiles.Text, out outParse))
            {
                messagesLabel.Text = "Enter a number of miles.";
            }
            else
            {
                // Check if there is enough fuel for the drive
                if ((myVehicle.FuelCurrent - (Convert.ToDouble(txtMiles.Text) / myVehicle.Mpg)) >= 0)
                {
                    myVehicle.Drive(Convert.ToDouble(txtMiles.Text));
                    messagesLabel.Text = "Drove " + txtMiles.Text + " miles.\n";
                    messagesLabel.Text += "Current fuel: " + myVehicle.FuelCurrent.ToString("F") + " gallons.";
                }
                else
                {
                    messagesLabel.Text = "Not enough fuel for this drive.\n";
                    messagesLabel.Text += "Current fuel: " + myVehicle.FuelCurrent.ToString("F") + " gallons.\n";
                    messagesLabel.Text += "Can only drive < " + (myVehicle.FuelCurrent * myVehicle.Mpg).ToString("F") + " miles.\n";
                    messagesLabel.Text += "Reduce miles or refuel.";
                }
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnOil_Click(object sender, EventArgs e)
        {
            double cost = myVehicle.ChangeOil();
            funds -= cost;
            myVehicle.OilAlert = false;
            fundsLabel.Text = funds.ToString("C");
            messagesLabel.Text = "Changed oil for " + cost.ToString("C") + ".\n";
            messagesLabel.Text += "Next oil change in " + myVehicle.OilCondition.ToString("F") + " miles.";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnTires_Click(object sender, EventArgs e)
        {
            double cost = myVehicle.ReplaceTires();
            funds -= cost;
            myVehicle.TireAlert = false;
            fundsLabel.Text = funds.ToString("C");
            messagesLabel.Text = "Tires replaced for " + cost.ToString("C") + ".\n";
            messagesLabel.Text += "Next tire replacement in " + myVehicle.TireCondition.ToString("F") + " miles.";
        }

        private void btnBrakes_Click(object sender, EventArgs e)
        {
            double cost = myVehicle.ReplaceBreaks();
            funds -= cost;
            myVehicle.BreakAlert = false;
            fundsLabel.Text = funds.ToString("C");
            messagesLabel.Text = "Breaks replaced for " + cost.ToString("C") + ".\n";
            messagesLabel.Text += "Next break replacement in " + myVehicle.BreakCondition.ToString("F") + " miles.";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Refill fuel, subtract refill cost from funds, display messages 
        private void btnFuel_Click(object sender, EventArgs e)
        {
            if(myVehicle.FuelCurrent < myVehicle.FuelCapacity)
            {
                double cost = myVehicle.AddFuel();
                funds -= cost;
                fundsLabel.Text = funds.ToString("C");
                messagesLabel.Text = "Refilled fuel for " + cost.ToString("C") + ".";
            }
            else
                messagesLabel.Text = "Fuel is already full.";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Displays vehicle maintaince stats
        private void btnDiagnostics_Click(object sender, EventArgs e)
        {
            // toEmpty calculates total miles that can be driven before fuel equals 0.
            double toEmpty = myVehicle.FuelCurrent * myVehicle.Mpg;

            messagesLabel.Text = "Current fuel: " + myVehicle.FuelCurrent.ToString("F") + " gallons.\n";
            messagesLabel.Text += "Fuel capacity: " + myVehicle.FuelCapacity.ToString("F") + " gallons.\n";
            messagesLabel.Text += "MPG: " + myVehicle.Mpg.ToString("F") + " miles per gallon.\n";
            messagesLabel.Text += "Miles to empty: " + toEmpty.ToString("F") + " miles.\n";
            if(myVehicle.OilAlert == true)
                messagesLabel.Text += "Time to change oil!\n";
            else
                messagesLabel.Text += "Miles until oil change: " + myVehicle.OilCondition.ToString("F") + "\n";
            if (myVehicle.BreakAlert == true)
                messagesLabel.Text += "Time to change breaks!\n";
            else
                messagesLabel.Text += "Miles until break change: " + myVehicle.BreakCondition.ToString("F") + "\n";
            if (myVehicle.TireAlert == true)
                messagesLabel.Text += "Time to change tires!\n";
            else
                messagesLabel.Text += "Miles until tire change: " + myVehicle.TireCondition.ToString("F") + "\n";
        }

        private void rbCar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSuv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMotorcycle_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Purchase a vehicle for testing, only 1 may be purchased
        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
            if (purchased == false)
            {
                if (rbCar.Checked)
                {
                    myVehicle = new Car();
                    messagesLabel.Text += "Car purchased for " + myVehicle.BaseCost.ToString("C") + "\n";
                    funds -= myVehicle.BaseCost;
                    rbSuv.Visible = false;
                    rbMotorcycle.Visible = false;
                }
                else if (rbSuv.Checked)
                {
                    myVehicle = new Suv();
                    messagesLabel.Text += "SUV purchased for " + myVehicle.BaseCost.ToString("C") + "\n";
                    funds -= myVehicle.BaseCost;
                    rbCar.Visible = false;
                    rbMotorcycle.Visible = false;
                }
                else
                {
                    myVehicle = new Motorcycle();
                    messagesLabel.Text += "Motorcycle purchased for " + myVehicle.BaseCost.ToString("C") + "\n";
                    funds -= myVehicle.BaseCost;
                    rbCar.Visible = false;
                    rbSuv.Visible = false;
                }
                purchased = true;
                fundsLabel.Text = funds.ToString("C");
                displayButtons();
            }
        }

        // Allows user to purchase new vehicle, resets variables, and erases messages
        private void btnReset_Click(object sender, EventArgs e)
        {
            funds = 50000;
            fundsLabel.Text = funds.ToString("C");
            purchased = false;
            messagesLabel.Text = "";
            hideButtons();
            txtMiles.Text = string.Empty;
        }
    }
}
