
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VehicleRentalSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Event Handler for Calculate Button
        private void btncalculate_Click(object sender, EventArgs e)
        {
            // Clear previous results
            lstresults.Items.Clear();

            // 1. Customer Name Validation
            string customerName = txtname.Text.Trim();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show(
                    "Please enter the customer's name.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtname.Focus();
                return;
            }

            // 2. Customer Age Validation
            if (!int.TryParse(txtage.Text.Trim(), out int age))
            {
                MessageBox.Show(
                    "Please enter a valid numeric age.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtage.Focus();
                return;
            }

            if (age < 18 || age > 80)
            {
                MessageBox.Show(
                    "Customer age must be between 18 and 80 years.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtage.Focus();
                return;
            }

            // 3. Rental Days Validation
            if (!int.TryParse(txtdays.Text.Trim(), out int days))
            {
                MessageBox.Show(
                    "Please enter a valid number of rental days.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtdays.Focus();
                return;
            }

            if (days < 1 || days > 30)
            {
                MessageBox.Show(
                    "Rental days must be between 1 and 30 days.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtdays.Focus();
                return;
            }

            // 4. Driving Experience Validation
            if (!int.TryParse(txtexperience.Text.Trim(), out int experience))
            {
                MessageBox.Show(
                    "Please enter valid years of driving experience.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtexperience.Focus();
                return;
            }

            if (experience < 0)
            {
                MessageBox.Show(
                    "Driving experience cannot be negative.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtexperience.Focus();
                return;
            }

            // 5. General Eligibility Rules
            if (age < 21)
            {
                MessageBox.Show(
                    "Customers below 21 years of age are not eligible to rent.",
                    "Eligibility Rejected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (experience < 1)
            {
                MessageBox.Show(
                    "Customers must have at least 1 year of driving experience.",
                    "Eligibility Rejected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // 6. Vehicle Selection and Daily Rate
            string vehicleType = "";
            decimal dailyRate = 0m;

            if (rdoeconomy.Checked)
            {
                vehicleType = "Economy";
                dailyRate = 35m;
            }
            else if (rdosuv.Checked)
            {
                vehicleType = "SUV";
                dailyRate = 60m;
            }
            else if (rdoluxury.Checked)
            {
                vehicleType = "Luxury";
                dailyRate = 100m;

                // Luxury Vehicle Restrictions
                if (age < 25 || experience < 3)
                {
                    MessageBox.Show(
                        "Luxury vehicles require at least 25 years of age and 3 years of driving experience.",
                        "Eligibility Rejected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a vehicle type.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // 7. Calculate Basic Rental Cost
            decimal basicRentalCost = dailyRate * days;

            // 8. Calculate Discount
            decimal discountPercentage = 0m;

            if (days >= 14)
            {
                discountPercentage = 0.10m; // 10% discount
            }
            else if (days >= 7)
            {
                discountPercentage = 0.05m; // 5% discount
            }

            decimal discountAmount =
                basicRentalCost * discountPercentage;

            // 9. Calculate Insurance Cost
            decimal insuranceCost = 0m;

            if (chkinsurance.Checked)
            {
                insuranceCost = 15m * days; // $15 per day
            }

            // 10. Calculate Young Driver Surcharge
            decimal youngDriverSurcharge = 0m;

            if (age >= 21 && age <= 24)
            {
                youngDriverSurcharge =
                    basicRentalCost * 0.10m; // 10% surcharge
            }

            // 11. Calculate Final Rental Cost
            decimal finalRentalCost =
                basicRentalCost
                - discountAmount
                + insuranceCost
                + youngDriverSurcharge;

            // 12. Display Rental Results
            lstresults.Items.Add("RENTAL DETAILS");
            lstresults.Items.Add("------------------------------------------");

            lstresults.Items.Add(
                string.Format("{0,-24}: {1}", "Customer Name", customerName));

            lstresults.Items.Add(
                string.Format("{0,-24}: {1}", "Customer Age", age));

            lstresults.Items.Add(
                string.Format("{0,-24}: {1} year(s)", "Driving Experience", experience));

            lstresults.Items.Add(
                string.Format("{0,-24}: {1}", "Vehicle Type", vehicleType));

            lstresults.Items.Add(
                string.Format("{0,-24}: {1:C}", "Daily Rate", dailyRate));

            lstresults.Items.Add(
                string.Format("{0,-24}: {1}", "Rental Days", days));

            lstresults.Items.Add(
                string.Format("{0,-24}: {1:C}", "Basic Rental Cost", basicRentalCost));

            lstresults.Items.Add(
                string.Format("{0,-24}: {1:C}", "Discount", discountAmount));

            lstresults.Items.Add(
                string.Format("{0,-24}: {1:C}", "Insurance Cost", insuranceCost));

            lstresults.Items.Add(
                string.Format("{0,-24}: {1:C}", "Young Driver Surcharge", youngDriverSurcharge));

            lstresults.Items.Add("------------------------------------------");

            lstresults.Items.Add(
                string.Format("{0,-24}: {1:C}", "FINAL RENTAL COST", finalRentalCost));

            lstresults.Items.Add("------------------------------------------");

            lstresults.Items.Add("Rental Status: Approved");
        }

        // Event Handler for Clear Button
        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear all TextBoxes
            txtname.Clear();
            txtage.Clear();
            txtdays.Clear();
            txtexperience.Clear();

            // Reset RadioButtons
            rdoeconomy.Checked = false;
            rdosuv.Checked = false;
            rdoluxury.Checked = false;

            // Reset Insurance CheckBox
            chkinsurance.Checked = false;

            // Clear previous results
            lstresults.Items.Clear();

            // Focus on Customer Name
            txtname.Focus();
        }

        // Event Handler for Exit Button
        private void btnexit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        private void rdosuv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
