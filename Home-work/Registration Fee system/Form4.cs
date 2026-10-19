using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoomBooking
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Form load event logic if needed
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // 1. Validate Courses (1 - 8)
            if (!int.TryParse(txtcourses.Text.Trim(), out int numberOfCourses) || numberOfCourses < 1 || numberOfCourses > 8)
            {
                MessageBox.Show("Please enter a valid number of courses between 1 and 8.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcourses.Focus();
                return;
            }

            // 2. Validate Study Level (1 - 4)
            if (!int.TryParse(txtlevel.Text.Trim(), out int studyYear) || studyYear < 1 || studyYear > 4)
            {
                MessageBox.Show("Please enter a valid study level between 1 and 4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlevel.Focus();
                return;
            }

            // Get top input values
            string studentName = txtname.Text.Trim();
            string studentId = txtid.Text.Trim();

            // 3. Determine Fee per Course based on year
            decimal feePerCourse = 0m;
            if (studyYear == 1) feePerCourse = 40m;
            else if (studyYear == 2) feePerCourse = 45m;
            else if (studyYear == 3) feePerCourse = 50m;
            else if (studyYear == 4) feePerCourse = 55m;

            // 4. Calculate Tuition Fee
            decimal tuitionFee = numberOfCourses * feePerCourse;

            // 5. Get Transport Fee
            decimal transportFee = 0m;
            if (decimal.TryParse(txtfee.Text.Trim(), out decimal enteredTransport))
            {
                transportFee = enteredTransport;
            }

            // 6. Calculate Discount (10% for 6 or more courses)
            decimal discountAmount = 0m;
            if (numberOfCourses >= 6)
            {
                discountAmount += tuitionFee * 0.10m;
            }

            // 7. Calculate Final Total Amount
            decimal finalAmount = (tuitionFee + transportFee) - discountAmount;

            // 8. Set text color to Green for the 8 output textboxes
            txtoutname.ForeColor = Color.Green;
            txtoutid.ForeColor = Color.Green;
            txtoutcourses.ForeColor = Color.Green;
            txtoutlevel.ForeColor = Color.Green;
            txtouttransport.ForeColor = Color.Green;
            txtoutdiscount.ForeColor = Color.Green;
            txtoutfee.ForeColor = Color.Green;
            txtoutfinal.ForeColor = Color.Green;

            // Display results in the 8 output textboxes
            txtoutname.Text = "Name : " + studentName;
            txtoutid.Text = "Id : " + studentId;
            txtoutcourses.Text = "Number Courses : " + numberOfCourses;
            txtoutlevel.Text = "Study year : " + studyYear;
            txtouttransport.Text = "Transport Fee : " + transportFee;
            txtoutdiscount.Text = "Discount : " + discountAmount;
            txtoutfee.Text = "Tuition fee : " + tuitionFee;
            txtoutfinal.Text = "Final Amount : " + finalAmount;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear Input Textboxes
            txtname.Clear();
            txtid.Clear();
            txtcourses.Clear();
            txtlevel.Clear();
            txtfee.Clear();

            // Clear Output Textboxes
            txtoutname.Clear();
            txtoutid.Clear();
            txtoutcourses.Clear();
            txtoutlevel.Clear();
            txtouttransport.Clear();
            txtoutdiscount.Clear();
            txtoutfee.Clear();
            txtoutfinal.Clear();

            txtname.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}