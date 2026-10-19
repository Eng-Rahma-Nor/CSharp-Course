using System;
using System.Windows.Forms;

namespace RoomBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            CalculateRoomBooking();
        }

        private void Btncalculate_Click(object sender, EventArgs e)
        {
            CalculateRoomBooking();
        }

        private void CalculateRoomBooking()
        {
            string guestName = txtname.Text.Trim();

            if (string.IsNullOrWhiteSpace(guestName))
            {
                MessageBox.Show("Please enter the guest name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
                return;
            }

            // Age validation oo la dejiyay si uusan marna error u keenin
            int age = 20; // Default ahaan haddii uu akhrin waayo
            if (!int.TryParse(txtage.Text.Trim(), out age))
            {
                age = 20;
            }

            // Nights validation
            int nights = 1;
            if (!int.TryParse(txtnights.Text.Trim(), out nights) || nights < 1)
            {
                nights = 1;
            }

            // Guests validation
            int guests = 1;
            if (!int.TryParse(txtguests.Text.Trim(), out guests) || guests < 1)
            {
                guests = 1;
            }

            string roomType = "";
            decimal roomRate = 0m;
            int maxGuests = 6;

            if (txtstandard.Checked)
            {
                roomType = "Standard";
                roomRate = 50m;
                maxGuests = 2;
            }
            else if (txtnormal.Checked)
            {
                roomType = "Normal";
                roomRate = 80m;
                maxGuests = 4;
            }
            else if (txthight.Checked)
            {
                roomType = "High";
                roomRate = 130m;
                maxGuests = 6;
            }
            else
            {
                roomType = "Standard";
                roomRate = 50m; // Default room haddii aan la dooran
            }

            // Xisaabaadka
            decimal roomCost = roomRate * nights;

            decimal nightDiscountRate = 0m;
            if (nights >= 10) nightDiscountRate = 0.12m;
            else if (nights >= 5) nightDiscountRate = 0.05m;

            decimal nightDiscount = roomCost * nightDiscountRate;
            decimal seniorDiscount = (age >= 60) ? roomCost * 0.10m : 0m;
            decimal discountedRoomCost = roomCost - nightDiscount - seniorDiscount;
            decimal serviceSurcharge = (guests > 4) ? discountedRoomCost * 0.05m : 0m;
            decimal breakfastCost = txtbreakfast.Checked ? (10m * guests * nights) : 0m;
            decimal totalCost = discountedRoomCost + serviceSurcharge + breakfastCost;

            // Ku soo bandhigida listBox1 si toos ah
            listBox1.Items.Clear();
            listBox1.Items.Add("Booking approved!");
            listBox1.Items.Add("------------------------------------");
            listBox1.Items.Add("Guest Name: " + guestName);
            listBox1.Items.Add("Age: " + age);
            listBox1.Items.Add("Room Type: " + roomType);
            listBox1.Items.Add("Rate Per Night: $" + roomRate.ToString("0"));
            listBox1.Items.Add("Nights: " + nights);
            listBox1.Items.Add("Guests: " + guests);
            listBox1.Items.Add("Room Cost: $" + roomCost.ToString("0"));
            listBox1.Items.Add("Stay Discount: " + (nightDiscountRate * 100).ToString("0") + "%");
            listBox1.Items.Add("Stay Discount Amount: $" + nightDiscount.ToString("0"));
            listBox1.Items.Add("Senior Discount: " + (age >= 60 ? "10%" : "0%"));
            listBox1.Items.Add("Senior Discount Amount: $" + seniorDiscount.ToString("0"));
            listBox1.Items.Add("Breakfast Cost: $" + breakfastCost.ToString("0"));
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
            txtnights.Text = string.Empty;
            txtguests.Text = string.Empty;

            txtstandard.Checked = false;
            txtnormal.Checked = false;
            txthight.Checked = false;
            txtbreakfast.Checked = false;

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
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}