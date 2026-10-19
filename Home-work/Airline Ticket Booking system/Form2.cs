using System;
using System.Windows.Forms;

namespace RoomBooking
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            CalculateBooking();
        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {
            CalculateBooking();
        }

        private void CalculateBooking()
        {
            string passengerName = txtname.Text.Trim();

            if (string.IsNullOrWhiteSpace(passengerName))
            {
                MessageBox.Show("Please enter the passenger name.", "Validation Error");
                txtname.Focus();
                return;
            }

            // Isticmaal int.TryParse caadi ah, haddii uu ku guuldarraystana u dhiib da'da default ahaan (tusaale 20) si uusan error u keenin
            int age = 20;
            if (!int.TryParse(txtage.Text.Trim(), out age))
            {
                age = 20; // Si uusan dib danbe u dhaginin oo uusan error u keenin
            }

            int tickets = 1;
            if (!int.TryParse(txttickets.Text.Trim(), out tickets))
            {
                tickets = 1;
            }

            decimal baggage = 0m;
            decimal.TryParse(txtbuggage.Text.Trim(), out baggage);

            string travelClass = "";
            decimal classRate = 0m;

            if (txtfirst.Checked)
            {
                travelClass = "First Class";
                classRate = 200m;
            }
            else if (txtnormal.Checked)
            {
                travelClass = "Normal Class";
                classRate = 100m;
            }
            else if (txtbusiness.Checked)
            {
                travelClass = "Business Class";
                classRate = 150m;
            }
            else
            {
                travelClass = "Standard Class";
                classRate = 100m; // Si uusan halkaasna ugu hakan haddii uusan dooran
            }

            // Xisaabaadka
            decimal baseCost = classRate * tickets;
            decimal insuranceCost = txtinsurance.Checked ? (25m * tickets) : 0m;
            decimal totalCost = baseCost + insuranceCost;

            // Ku soo bandhigida ListBox1
            listBox1.Items.Clear();
            listBox1.Items.Add("Booking approved!");
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Passenger Name: " + passengerName);
            listBox1.Items.Add("Passenger Age: " + age);
            listBox1.Items.Add("Travel Class: " + travelClass);
            listBox1.Items.Add("Rate Per Ticket: $" + classRate.ToString("0"));
            listBox1.Items.Add("Number of Tickets: " + tickets);
            listBox1.Items.Add("Baggage Weight: " + baggage + " kg");
            listBox1.Items.Add("Base Cost: $" + baseCost.ToString("0"));
            listBox1.Items.Add("Insurance Cost: $" + insuranceCost.ToString("0"));
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Total Cost: $" + totalCost.ToString("0"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtname.Text = string.Empty;
            txtage.Text = string.Empty;
            txttickets.Text = string.Empty;
            txtbuggage.Text = string.Empty;

            txtfirst.Checked = false;
            txtnormal.Checked = false;
            txtbusiness.Checked = false;
            txtinsurance.Checked = false;

            listBox1.Items.Clear();
            txtname.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void ExitApp()
        {
            Application.Exit();
        }
    }
}