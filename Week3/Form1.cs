using System;
using System.Windows.Forms;

namespace AssignmentONE
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

        // Calculate Button
        private void calculate_Click(object sender, EventArgs e)
        {
            // Creating variables
            string Food1, Food2;
            double p_Food1, p_Food2;
            double Sales_Text, Tips, Amount, NetAmount;
            double TipRate;

            // Constant value
            const double Sales_Vat = 5; // ama 7 sida aad doonto

            try
            {
                // Get food names
                Food1 = txtfood1.Text;
                Food2 = txtfood2.Text;

                // Get food prices (.Trim() wuxuu ka tirtirayaa space-ka)
                p_Food1 = double.Parse(txtpricefood1.Text.Trim());
                p_Food2 = double.Parse(txtpricefood2.Text.Trim());

                // Get Tips percentage
                TipRate = double.Parse(txtamounttips.Text.Trim());

                // 1. Calculate total amount
                Amount = p_Food1 + p_Food2;

                // 2. Calculate Sales VAT
                Sales_Text = Amount * (Sales_Vat / 100);

                // 3. Calculate Tips
                Tips = Amount * (TipRate / 100);

                // 4. Calculate Net Amount (Fikradda saxda ah: Tax-ka waa ka go'ayaa Total-ka)
                NetAmount = Amount - Sales_Text;

                // Display outputs formatted as Currency / Standard numbers
                textBox1.Text = Sales_Text.ToString("C2");  // Sales Tax
                textBox2.Text = Tips.ToString("C2");        // Tips
                textBox3.Text = Amount.ToString("C2");      // Total Amount
                textBox4.Text = NetAmount.ToString("C2");   // Net Amount
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Fadlan geli tirooyin sax ah!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Clear Button
        // Clear Button
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

            // Focus on Food 1
            txtfood1.Focus();
        }
        // Close Button
        private void closebtn_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void btnamount_Click_1(object sender, EventArgs e)
        {
        }

        private void lblsales_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}