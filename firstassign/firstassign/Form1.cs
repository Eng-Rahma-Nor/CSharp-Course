using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace firstassign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Button Calculate
        private void calculate_Click(object sender, EventArgs e)
        {
            // Creating variables
            string Food1, Food2;
            double p_Food1, p_Food2, Sales_Text, Tips, Amount;

            // Const variables
            const double Sales_Vat = 5;
            const double Tips_Vat = 15;

            // Exception handling
            try
            {
                // Assigning variables
                Food1 = txtfood1.Text;
                Food2 = txtfood2.Text;

                // Assigning prices using Parse method
                p_Food1 = double.Parse(txtpricefood1.Text);
                p_Food2 = double.Parse(txtpricefood2.Text);

                // Process
                // Calculate the total amount
                Amount = p_Food1 + p_Food2;

                // Calculate Sales VAT
                Sales_Text = Amount * (Sales_Vat / 100);

                // Calculate Tips
                Tips = Amount * (Tips_Vat / 100);

                // Output
                // TextBox1 = Sales VAT
                textBox1.Text = Sales_Text.ToString();

                // TextBox2 = Tips
                textBox2.Text = Tips.ToString();

                // TextBox3 = Total Amount
                textBox3.Text = Amount.ToString();

                // TextBox4 = Net Amount
                textBox4.Text = (Amount + Sales_Text + Tips).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Fadlan gali tirooyin sax ah!",
                    "Error"
                );
            }
        }

        // Button Clear
        private void clearbtn_Click(object sender, EventArgs e)
        {
            // Clear input TextBoxes
            txtfood1.Text = "";
            txtpricefood1.Text = "";
            txtfood2.Text = "";
            txtpricefood2.Text = "";
            txtamounttips.Text = "";

            // Clear output TextBoxes
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            // Set focus back to Food1
            txtfood1.Focus();
        }

        // Button Close
        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnamount_Click_1(object sender, EventArgs e)
        {

        }

        private void lblsales_Click(object sender, EventArgs e)
        {

        }
    }
}