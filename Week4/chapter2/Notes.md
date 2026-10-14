C# Chapter 2: Processing Data — Comprehensive Notes (Slide 39 Onward)

1. Declaring Variables as Fields (Section 3.9)

What is a Field?

A field (or field variable) is a variable declared inside a class body but outside any method.

Scope vs. Lifetime

Scope: A field is accessible to all methods declared within the same class.

Lifetime: A field exists in memory as long as the instance of the class (or Form) exists. It is created when the form is instantiated and destroyed when the form is closed.

public partial class MainForm : Form
{
    // Declaring a class-level field variable
    private double totalBalance = 0.0;

    private void depositButton_Click(object sender, EventArgs e)
    {
        double amount = double.Parse(amountTextBox.Text);
        totalBalance += amount; // Field updated across methods
    }

    private void showBalanceButton_Click(object sender, EventArgs e)
    {
        balanceLabel.Text = totalBalance.ToString("C");
    }
}


2. Using the Math Class (Section 3.10)

The .NET Framework provides a static Math class containing methods and constants for mathematical operations.

Key Math Methods

Method

Description

Example

Result

Math.Sqrt(x)

Returns the square root of $x$ (returns double).

Math.Sqrt(16)

4.0

Math.Pow(x, y)

Returns $x$ raised to the power of $y$ ($x^y$).

Math.Pow(2, 3)

8.0

Math.Max(x, y)

Returns the larger of two numbers.

Math.Max(10, 20)

20

Math.Min(x, y)

Returns the smaller of two numbers.

Math.Min(10, 20)

10

Math.Round(x)

Rounds a value to the nearest integer.

Math.Round(3.75)

4.0

Math Constants

Math.PI: Value of $\pi \approx 3.141592653589793$

Math.E: Natural logarithmic base $e \approx 2.718281828459045$

Example: Calculating Hypotenuse ($c = \sqrt{a^2 + b^2}$)

double a = 3.0;
double b = 4.0;
double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)); // Result: 5.0


3. Advanced GUI Details (Section 3.11)

Tab Order and Focus

Focus: The control on a form that currently accepts user keyboard input.

Tab Order: The order in which controls receive focus when the user repeatedly presses the Tab key.

Changing Tab Order: Go to View $\rightarrow$ Tab Order in Visual Studio, then click controls in the preferred sequence (starting at index 0).

Programmatic Focus: Use the .Focus() method to set focus to a specific control.

inputTextBox.Focus();


Access Keys (Mnemonics)

An access key is a keyboard shortcut (Alt + key) that triggers a button or moves focus to a control.

Assign an ampersand (&) before the target letter in the control's Text property.

Example: Setting button text to E&xit creates shortcut Alt + X.

Form & Control Styling

Colors: Controls support BackColor and ForeColor.

resultLabel.BackColor = Color.Black;
resultLabel.ForeColor = Color.Yellow;


Background Images: Set the BackgroundImage property and adjust BackgroundImageLayout (e.g., Stretch, Tile, Center).

Container Controls: GroupBox vs. Panel

Both serve as containers to group related controls, but they differ in design and features:

Feature

GroupBox

Panel

Title/Header

Displays a header text (Text property)

Does not have a header text

Border Style

Standard thin outer border

Configurable via BorderStyle

Scrollbars

Not supported

Supports automatic scrollbars (AutoScroll = true)

4. Debugging & Logic Errors (Section 3.12)

Understanding Logic Errors

A Logic Error (bug) occurs when code runs without crashing, but produces incorrect calculations or unintended results.

Visual Studio Debugging Tools

Breakpoints: A marker set on a line of code that pauses application execution during runtime.

Shortcut: Press F9 on a selected code line.

Break Mode: The execution state reached when a breakpoint is hit.

Hover mouse over variables to inspect current values in real-time.

Inspection Windows:

Locals Window: Automatically displays all variables active in the current method scope.

Watch Window: Allows custom tracking of specific expressions or variables.

Single-Stepping:

F11 (Step Into): Executes code one line at a time, stepping into called methods.

F10 (Step Over): Executes code line by line without stepping inside called methods.