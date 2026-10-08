Chapter 2: Processing Data — Notes
Data Types

C# uses different data types for different kinds of values.

int

int stores whole numbers.

int age = 20;
int hoursWorked = 40;

It should not be used for values containing a decimal part.

double

double stores numbers that can contain decimal values.

double distance = 28.75;
double speed = 75;
decimal

decimal is useful when working with precise decimal values, especially money.

decimal balance = 9280.73m;
decimal price = 50m;

The m tells C# that the value is a decimal literal.

Assignment Compatibility

The value assigned to a variable must be compatible with the variable's data type.

For example:

int hoursWorked = 40;

is valid because 40 is a whole number.

But:

int score = -25.5;

is not compatible with int because it contains a fractional part.

Casting

Casting means explicitly converting a value from one type to another.

decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;

The (int) tells C# to convert the value to an integer.

Another example:

decimal moneyNumber = 625.70m;
double realNumber = (double)moneyNumber;
The var Keyword

var lets C# determine the data type automatically from the initial value.

var interestRate = 12.0;
var stockCode = "D465U";
var accountBalance = 1000.0m;

The variable still has a specific type; var does not mean the variable can change type later.

The variable must have a value when it is declared.

Arithmetic Operators

Remember these operators:

+   Addition
-   Subtraction
*   Multiplication
/   Division
%   Remainder

Example:

int x = 5;
int y = 4;

int result = x + y;

Parentheses are useful when you want to control the order of calculations.

Integer Division

This is important for exams and programming exercises.

int x = 7;
int y = 3;

int result = x / y;

The result is:

2

The decimal part is removed because both operands are integers.

To get the decimal result:

double result = (double)x / y;

The result is approximately:

2.333333...
TextBox Input

When a user types something into a TextBox, C# receives it as a string.

For example, if the user enters:

40

the TextBox still contains text.

If the program needs a number, use Parse.

int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

For a double:

double temperature = double.Parse(temperatureTextBox.Text);

For a decimal:

decimal price = decimal.Parse(priceTextBox.Text);
ToString()

Use ToString() when a numeric value needs to be displayed as text.

int number = 123;
MessageBox.Show(number.ToString());

It can also be used with a Label:

decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();
Number Formatting

Formatting controls how a number appears to the user.

Number
12.3.ToString("n3");

Result:

12.300
Fixed Point
123456.0.ToString("f2");

Result:

123456.00
Exponential
123456.0.ToString("e3");

This displays the number in exponential form.

Currency
1234567.8.ToString("C");

This displays the value as currency.

Percentage
0.234.ToString("P");

Result:

23.40%
Exceptions

An exception is a problem that occurs while the program is running.

Common examples:

Invalid numeric input.
Division by zero.
A file that cannot be found.

Without exception handling, a runtime error can cause the program to stop.

try and catch

The try block contains code that might produce an exception.

The catch block handles the exception.

try
{
    // Possible problem
}
catch
{
    // Handle problem
}
Example
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

If the input is invalid, the program goes to the catch section.

Exception Message

The exception itself can be stored in a variable.

catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}

ex.Message gives information about what went wrong.

Throwing and Catching

Throwing: the error/problem occurs.

Catching: the program receives the exception and handles it.

A simple way to remember it:

Problem happens → Exception is thrown
                ↓
             catch
                ↓
        Program handles it