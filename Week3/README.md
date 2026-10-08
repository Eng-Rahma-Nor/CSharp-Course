Chapter 2: Processing Data

This chapter explains how C# works with different types of data, performs calculations, receives numeric input, displays numbers, formats values, and handles simple runtime errors.

Assignment Compatibility

Different variables use different data types.

int is used for whole numbers.
double is used for numbers that can contain decimal values.
decimal is used when more precise decimal values are needed, especially for financial values.

The value assigned to a variable must be compatible with its data type.

int hoursWorked = 40;
double distance = 28.75;
decimal balance = 9280.73m;

For decimal values, the m suffix is used with the decimal type.

Explicit Conversion

Sometimes a value needs to be changed from one data type to another. This is called casting or explicit conversion.

The target data type is written inside parentheses.

decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;

A decimal value can also be converted to a double.

decimal moneyNumber = 625.70m;
double realNumber = (double)moneyNumber;
Using var

The var keyword allows C# to determine the variable's data type from the value assigned to it.

var interestRate = 12.0;
var stockCode = "D465U";
var accountBalance = 1000.0m;

A variable declared with var must be initialized when it is created.

Arithmetic Calculations

C# provides arithmetic operators for calculations:

Operator	Meaning
+	Addition
-	Subtraction
*	Multiplication
/	Division
%	Remainder

Example:

int x = 5;
int y = 4;

MessageBox.Show((x + y).ToString());

Parentheses can be used to control the order in which calculations are performed.

Calculations with Different Data Types

When different numeric types are used together, the result depends on the types involved.

int and double produce a double result.
int and decimal produce a decimal result.
double and decimal cannot be used directly together.
Integer Division

When two integers are divided, C# performs integer division.

int x = 7;
int y = 3;

int result = x / y;

The result is 2, not 2.333..., because both values are integers.

To get a decimal result, one of the values can be converted to double.

double result = (double)x / y;
Reading Numeric Input

TextBox input is stored as a string, even when the user enters a number.

For example:

int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

The Parse method converts the text into a numeric value.

Common examples include:

int.Parse()
double.Parse()
decimal.Parse()

For example:

double temperature = double.Parse(temperatureTextBox.Text);
Displaying Numeric Values

A TextBox, Label, or MessageBox expects text when displaying a value.

The ToString() method can convert a numeric value into a string.

decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();

Another example:

int myNumber = 123;
MessageBox.Show(myNumber.ToString());

Numbers can also be combined with text using the + operator.

MessageBox.Show("Your ID number is " + idNumber);
Formatting Numbers

The ToString() method can also format numbers.

Common formats include:

Format	Purpose
N	Number
F	Fixed-point
E	Exponential
C	Currency
P	Percentage

Examples:

12.3.ToString("n3");

Produces:

12.300
123456.0.ToString("f2");

Produces:

123456.00
123456.0.ToString("e3");

Produces an exponential representation.

0.234.ToString("P");

Produces:

23.40%
Exception Handling

An exception is an unexpected problem that happens while a program is running.

Examples include:

Dividing by zero.
Entering invalid data.
Trying to access a file that does not exist.

Exception handling allows the program to respond to the problem instead of stopping unexpectedly.

The basic structure uses try and catch.

try
{
    // Code that may cause an error
}
catch
{
    // Code that handles the error
}

The try block contains code that may cause an exception.

The catch block handles the exception.

Example of Exception Handling
private void calculateButton_Click(object sender, EventArgs e)
{
    try
    {
        double miles;
        double gallons;
        double mpg;

        miles = double.Parse(milesTextBox.Text);
        gallons = double.Parse(gallonsTextBox.Text);
        mpg = miles / gallons;

        mpgLabel.Text = mpg.ToString();
    }
    catch
    {
        MessageBox.Show("Invalid data was entered.");
    }
}

When an error occurs inside the try block, the program moves to the catch block.

Exception Object

An exception is an object and contains information about the error.

The Message property can be used to display the error message.

try
{
    statement;
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
Important Terms

Throwing means an error or problem occurs.

Catching means the program handles the error and decides what to do.

Key Takeaways
Choose a data type that matches the value being stored.
Use casting when an explicit conversion is needed.
var allows C# to infer a variable's type.
Use arithmetic operators to perform calculations.
Remember that integer division removes the fractional part.
Use Parse to convert TextBox strings into numeric values.
Use ToString() to display numeric values.
Use number formats such as N, F, E, C, and P.
Use try and catch to handle runtime exceptions.