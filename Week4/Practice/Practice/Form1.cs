namespace Example_Of_Week_FOUR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCheckQuali_Click(object sender, EventArgs e)
        {
            // Variables
            double salary, yearsExperience, validation;

            // constant variable 
            const double YEARS_EXP = 2;

            // preventing Data Concvertion try parse
            // syntax - two argument one keyword out
            // double.tryparse(String, out target var)
            // target variable
            if (double.TryParse(TxtSalary.Text, out validation) & double.TryParse(TxtYearsExp.Text, out yearsExperience))
            {
                try
                {
                    // Assigning variables - user input to store variables
                    salary = double.Parse(TxtSalary.Text);
                    yearsExperience = double.Parse(TxtYearsExp.Text);

                    // validation
                    if (salary > 0 & yearsExperience > 0)
                    {
                        // check the load condition
                        // checking salary
                        if (salary >= 200) // true
                        {
                            // checking years of experience 
                            if (yearsExperience >= YEARS_EXP)
                            {
                                lblDesicion.Text = "Your Qualify on loan";
                            }
                            else
                            {
                                lblDesicion.Text = "You Experience must be Greater than 2 years";
                            }
                        }
                        else
                        {
                            lblDesicion.Text = "You Salary is less than 200 ";
                        }
                    }
                    else
                    {
                        lblDesicion.Text = "Salary and years of exprience must be Positive";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // validation - user input Greater 0
            }

            else
            {
                lblDesicion.Text = "Salary and Years of Experience Must be Integer";
            }


        }

        private void Lbl_Salary_Click(object sender, EventArgs e)
        {

        }

        private void lblDesicion_Click(object sender, EventArgs e)
        {
            // clear label text 
            lblDesicion.Text = String.Empty;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Exit the Application 
            this.Close();
        }

        private void BtnChangeClr_Click(object sender, EventArgs e)
        {
            // changing the buttons color and their fonts
            BtnCheckQuali.BackColor = Color.LimeGreen;
            BtnCheckQuali.ForeColor = Color.White;

            // changing the buttons color and their fonts
            BtnChangeClr.BackColor = Color.ForestGreen;
            BtnChangeClr.ForeColor = Color.White;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}