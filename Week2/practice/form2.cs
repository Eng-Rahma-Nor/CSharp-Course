using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PracticeForm : Form
    {
        public PracticeForm()
        {
            InitializeComponent();
        }

 
        // PRACTICAL 1 - LABEL
       

        private void showMessageButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "Halkan waa casharkii C#";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            greetingLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        // PRACTICAL 2 - TEXTBOX
       

        private void submitButton_Click(object sender, EventArgs e)
        {
            string userName = nameTextBox.Text;

            resultLabel.Text = "Soo dhawoow " + userName;
        }

        private void clearButton2_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            resultLabel.Text = "";

            nameTextBox.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // PRACTICAL 3 - PICTUREBOX
       

        private void showImageButton_Click(object sender, EventArgs e)
        {
            cardPicture.Visible = true;
        }

        private void hideImageButton_Click(object sender, EventArgs e)
        {
            cardPicture.Visible = false;
        }

        private void closeAppButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


   
        // PRACTICAL 4 - CALCULATION

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int hours = int.Parse(hoursTextBox.Text);
                decimal rate = decimal.Parse(rateTextBox.Text);

                decimal grossPay = hours * rate;

                payLabel.Text = grossPay.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Fadlan geli nambaro sax ah! Error: " + ex.Message
                );
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            hoursTextBox.Clear();
            rateTextBox.Clear();
            payLabel.Text = "";

            hoursTextBox.Focus();
        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //PRACTICAL 5

        // Show button - display the full name
        private void btnShow_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string secondName = txtSecondName.Text;

            // Combine the two names and display them in the Label
            lblFullName.Text = firstName + " " + secondName;
        }

        // Clear button - clear all fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtSecondName.Clear();
            lblFullName.Text = "";

            // Return the cursor to the first TextBox
            txtFirstName.Focus();
        }

        // Exit button - close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
     
        }

    }


}