# Week 2 Practical Notes

## C# Windows Forms — Controls, Events, TextBox, Label, PictureBox, and Exception Handling


## 1. Introduction

These practicals demonstrate how to create a simple Windows Forms application using C#.

The practicals focus on:

* Labels
* Buttons
* TextBoxes
* PictureBox
* Events
* Clearing controls
* Setting focus
* Closing a form
* Reading user input
* Basic calculations
* Exception handling using `try-catch`

All practicals can be created inside one Windows Form called `PracticeForm`.

---

# Practical 1 — Changing Label Text and Closing the Application

## Objective

The purpose of this practical is to learn how to:

* Change the text of a Label.
* Clear a Label.
* Close the current form.
* Handle button click events.

## Controls Used

| Control | Name              | Purpose            |
| ------- | ----------------- | ------------------ |
| Label   | `greetingLabel`   | Displays a message |
| Button  | `btnShowMessage`  | Displays a message |
| Button  | `btnClearMessage` | Clears the Label   |
| Button  | `btnExitMessage`  | Closes the form    |

## Main Concepts

### Label.Text

The `Text` property is used to change the text displayed by a Label.

```csharp
greetingLabel.Text = "Halkan waa casharkii C#";
```

**Somali:** Waxay Label-ka ku qoreysaa qoraalka cusub.

### Clearing a Label

A Label can be cleared by assigning an empty string:

```csharp
greetingLabel.Text = "";
```

### Closing the Form

```csharp
this.Close();
```

**Somali:** Waxay xiraysaa Form-ka hadda furan.

## Example Code

```csharp
private void btnShowMessage_Click(object sender, EventArgs e)
{
    greetingLabel.Text = "Halkan waa casharkii C#";
}

private void btnClearMessage_Click(object sender, EventArgs e)
{
    greetingLabel.Text = "";
}

private void btnExitMessage_Click(object sender, EventArgs e)
{
    this.Close();
}
```

## What I Learned

* How to change Label text.
* How to clear a Label.
* How to close a Windows Form.
* How to respond to Button click events.

---

# Practical 2 — TextBox Input, Clear, and Focus

## Objective

The purpose of this practical is to learn how to:

* Get text from a TextBox.
* Display the input in a Label.
* Clear a TextBox.
* Use `Focus()`.

## Controls Used

| Control | Name           | Purpose             |
| ------- | -------------- | ------------------- |
| Label   | `nameLabel`    | Displays "Name"     |
| TextBox | `nameTextBox`  | Accepts user input  |
| Label   | `resultLabel`  | Displays the result |
| Button  | `submitButton` | Processes the input |
| Button  | `clearButton2` | Clears the input    |
| Button  | `closeButton`  | Closes the form     |

## Reading TextBox Input

To read the text entered by the user:

```csharp
string userName = nameTextBox.Text;
```

**Somali:** Waxay TextBox-ka ka soo qaadaysaa qoraalka uu user-ku geliyay.

## Displaying the Result

```csharp
resultLabel.Text = "Soo dhawoow " + userName;
```

The `+` operator joins two strings together.

## Clear()

The `Clear()` method removes the text inside a TextBox.

```csharp
nameTextBox.Clear();
```

## Focus()

The `Focus()` method places the cursor inside a control.

```csharp
nameTextBox.Focus();
```

**Somali:** Cursor-ka wuxuu dib ugu celinayaa TextBox-ka.

## Example Code

```csharp
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
```

## What I Learned

* How to read input from a TextBox.
* How to combine strings.
* How to clear a TextBox.
* How to use `Focus()`.

---

# Practical 3 — PictureBox: Show and Hide an Image

## Objective

The purpose of this practical is to learn how to:

* Use a PictureBox.
* Show a PictureBox.
* Hide a PictureBox.
* Control visibility using a Button event.

## Control Used

| Control    | Name            | Purpose           |
| ---------- | --------------- | ----------------- |
| PictureBox | `picCard`       | Displays an image |
| Button     | `btnShowImage`  | Shows the image   |
| Button     | `btnHideImage`  | Hides the image   |
| Button     | `btnCloseImage` | Closes the form   |

## Visible Property

The `Visible` property controls whether a control appears on the Form.

### Show

```csharp
picCard.Visible = true;
```

`true` means the control is visible.

### Hide

```csharp
picCard.Visible = false;
```

`false` means the control is hidden.

## Example Code

```csharp
private void btnShowImage_Click(object sender, EventArgs e)
{
    picCard.Visible = true;
}

private void btnHideImage_Click(object sender, EventArgs e)
{
    picCard.Visible = false;
}

private void btnCloseImage_Click(object sender, EventArgs e)
{
    this.Close();
}
```

## What I Learned

* How to use PictureBox.
* How to control visibility.
* The difference between `true` and `false`.
* How to use Button click events.

---

# Practical 4 — Simple Calculation and Exception Handling

## Objective

The purpose of this practical is to learn how to:

* Read numbers from TextBoxes.
* Convert text into numbers.
* Perform a calculation.
* Display the result.
* Handle invalid input using `try-catch`.

## Controls Used

| Control | Name                  | Purpose              |
| ------- | --------------------- | -------------------- |
| Label   | `hoursLabel`          | Displays Hours       |
| TextBox | `txtHours`            | Accepts hours        |
| Label   | `rateLabel`           | Displays Rate        |
| TextBox | `txtRate`             | Accepts rate         |
| Label   | `lblPay`              | Displays gross pay   |
| Button  | `btnCalculate`        | Performs calculation |
| Button  | `btnClearCalculation` | Clears fields        |
| Button  | `btnExitCalculation`  | Closes the form      |

## Converting Text to Integer

```csharp
int hours = int.Parse(txtHours.Text);
```

The TextBox contains text, so `int.Parse()` converts the text into an integer.

## Converting Text to Decimal

```csharp
decimal rate = decimal.Parse(txtRate.Text);
```

`decimal` is useful for values involving money.

## Calculation

```csharp
decimal grossPay = hours * rate;
```

The formula is:

```text
Gross Pay = Hours × Rate
```

## Currency Formatting

```csharp
lblPay.Text = grossPay.ToString("C");
```

`"C"` formats the number as currency.

## try-catch

The `try-catch` statement prevents the application from crashing when invalid data is entered.

```csharp
try
{
    // Code that may produce an error
}
catch (Exception ex)
{
    // Code that handles the error
}
```

## Example Code

```csharp
private void btnCalculate_Click(object sender, EventArgs e)
{
    try
    {
        int hours = int.Parse(txtHours.Text);
        decimal rate = decimal.Parse(txtRate.Text);

        decimal grossPay = hours * rate;

        lblPay.Text = grossPay.ToString("C");
    }
    catch (Exception ex)
    {
        MessageBox.Show(
            "Fadlan geli nambaro sax ah! Error: " + ex.Message
        );
    }
}

private void btnClearCalculation_Click(object sender, EventArgs e)
{
    txtHours.Clear();
    txtRate.Clear();
    lblPay.Text = "";

    txtHours.Focus();
}

private void btnExitCalculation_Click(object sender, EventArgs e)
{
    this.Close();
}
```

## What I Learned

* How to convert text to numbers.
* How to calculate values.
* How to format currency.
* How to use `try-catch`.
* How to display an error message.

---

# Exercise — Full Name

## Objective

The exercise combines TextBoxes, Labels, Buttons, string variables, and events.

The user enters:

* First Name
* Second Name

The program combines both names and displays the full name.

## Controls Used

| Control | Name            | Purpose              |
| ------- | --------------- | -------------------- |
| Label   | `lblFirstName`  | Displays First Name  |
| TextBox | `txtFirstName`  | Accepts first name   |
| Label   | `lblSecondName` | Displays Second Name |
| TextBox | `txtSecondName` | Accepts second name  |
| Label   | `lblFullName`   | Displays full name   |
| Button  | `btnShow`       | Displays full name   |
| Button  | `btnClear`      | Clears all fields    |
| Button  | `btnExit`       | Closes the form      |

## Reading TextBox Values

```csharp
string firstName = txtFirstName.Text;
string secondName = txtSecondName.Text;
```

## Combining Strings

```csharp
lblFullName.Text = firstName + " " + secondName;
```

The `" "` adds a space between the two names.

For example:

```text
First Name: Rahma
Second Name: Nor

Result:
Rahma Nor
```

## Exercise Code

```csharp
private void btnShow_Click(object sender, EventArgs e)
{
    string firstName = txtFirstName.Text;
    string secondName = txtSecondName.Text;

    lblFullName.Text = firstName + " " + secondName;
}

private void btnClear_Click(object sender, EventArgs e)
{
    txtFirstName.Clear();
    txtSecondName.Clear();
    lblFullName.Text = "";

    txtFirstName.Focus();
}

private void btnExit_Click(object sender, EventArgs e)
{
    this.Close();
}
```

---

# Important C# Windows Forms Concepts

## 1. Event

An event is an action that happens in the application.

Examples:

```text
Button Click
Mouse Click
Keyboard Input
Form Load
```

A Button click event usually looks like:

```csharp
private void button_Click(object sender, EventArgs e)
{
}
```

---

## 2. TextBox.Text

Used to get or change the text in a TextBox.

```csharp
string name = txtName.Text;
```

---

## 3. Label.Text

Used to display or change text.

```csharp
lblResult.Text = "Hello";
```

---

## 4. Clear()

Removes text from a TextBox.

```csharp
txtName.Clear();
```

---

## 5. Focus()

Moves the cursor to a control.

```csharp
txtName.Focus();
```

---

## 6. Visible

Controls whether a control is displayed.

```csharp
picCard.Visible = true;
```

or:

```csharp
picCard.Visible = false;
```

---

## 7. Close()

Closes the current Form.

```csharp
this.Close();
```

---

## 8. MessageBox.Show()

Displays a message box.

```csharp
MessageBox.Show("Hello!");
```

It can also display an error:

```csharp
MessageBox.Show("Please enter valid numbers.");
```

---

# Summary

These practicals introduced the basic interaction between the user and a Windows Forms application.

The main concepts are:

```text
Label.Text
TextBox.Text
TextBox.Clear()
Control.Focus()
Control.Visible
this.Close()
MessageBox.Show()
Button Click Event
try-catch
int.Parse()
decimal.Parse()
ToString("C")
```

The general process is:

```text
User enters data
        ↓
Button is clicked
        ↓
Event handler runs
        ↓
C# processes the data
        ↓
Label / PictureBox displays the result
```

These concepts are important foundations for building interactive C# Windows Forms applications.
