# Chapter 3: Making Decisions - Comprehensive Study Notes

This chapter focuses on how C# programs can execute different paths of execution based on specific conditions, and how to handle various GUI controls and user input validation.

---

## 4.1 Decision Structures and the `if` Statement

* **Control Structures:** Define the order in which statements execute.


* *Sequence Structure:* Statements execute in the exact order they appear, line by line.


* *Decision Structure (Selection Structure):* Executes specific actions only under certain circumstances (when a condition evaluates to true).




* **Single-Alternative `if` Statement:** Evaluates a Boolean expression. If it is true, the block of statements inside executes; otherwise, it is skipped.


* **Relational Operators:** Used to determine the relationship between two values:


* `>` (Greater than)


* `<` (Less than)


* `>=` (Greater than or equal to)


* `<=` (Less than or equal to)


* `==` (Equal to)


* `!=` (Not equal to)





---

## 4.2 The `if-else` Statement

* An `if-else` statement provides two distinct paths of execution: one path if the condition is true, and an alternative path (`else`) if the condition is false.


* **Example Application:** Calculating a test score average and displaying a congratulatory message if it exceeds a high score threshold.



---

## 4.3 Nested Decision Structures & `if-else-if`

* **Nested Decision Structure:** Placing an `if` (or `if-else`) statement inside another `if` statement to test multiple dependent conditions sequentially (e.g., checking if a user meets a minimum salary requirement, and *then* checking their years at the current job for a loan).


* **`if-else-if` Statement:** Evaluates a chain of conditions to make a multi-alternative decision (ideal for grading scales such as A, B, C, D, or F based on scores).



---

## 4.4 Logical Operators

Logical operators allow you to combine multiple Boolean expressions into compound expressions:

* **`&&` (Logical AND):** Both sub-expressions must be true for the compound expression to be true.


* **`||` (Logical OR):** One or both sub-expressions must be true for the compound expression to be true.


* **`!` (Logical NOT):** Reverses the truth value of a Boolean expression (true becomes false, and vice versa).



---

## 4.5 `bool` Variables and Flags

* **`bool` Type:** Variables that store either `true` or `false` values.


* **Flag:** A `bool` variable used as a signal to indicate whether a specific condition exists or has occurred in the program (e.g., `isGrandMaster = true`).



---

## 4.6 Comparing Strings

* Strings can be compared using relational operators like `==` and `!=`, or built-in methods like `String.Compare()` and `CompareTo()`.



---

## 4.7 & 4.8 Preventing Data Conversion Exceptions & Input Validation

* **`TryParse` Methods:** Instead of letting `int.Parse` or `double.Parse` crash the application when a user enters invalid non-numeric text, `TryParse` safely attempts conversion and returns a boolean value (`true` or `false`).


* Syntax: `dataType.TryParse(string input, out targetVariable)`.




* **Input Validation:** The process of inspecting data entered by a user to ensure it is logical and within acceptable boundaries before using it in calculations (e.g., ensuring hours worked are between 0 and 168, or test scores are between 0 and 100).



---

## 4.9 Radio Buttons and Check Boxes

* **Radio Buttons:** Allow users to select a single choice from multiple mutually exclusive options. Selecting one automatically deselects the others in the same container.


* **Check Boxes:** Allow users to select multiple independent options simultaneously.


* **`Checked` Property:** A boolean property indicating whether the control is selected or deselected.


* **`CheckedChanged` Event:** Triggered automatically whenever the state of a radio button or check box changes.



---

## 4.10 The `switch` Statement

* A multi-alternative decision structure used as a cleaner alternative to a long `if-else-if` chain.


* Evaluates a test expression against multiple `case` labels. Each case must end with a `break` statement, and an optional `default` section handles values that do not match any case.



---

## 4.11 Introduction to List Boxes

* **`ListBox` Control:** Displays a scrolling list of items from which the user can select.


* **Key Properties and Methods:**
* `Items.Add(item)`: Adds a new item to the list box.


* `Items.Remove(item)` / `Items.RemoveAt(index)`: Removes an item by value or specific index.


* `Items.Clear()`: Erases all items from the list box.


* `SelectedIndex`: Returns the zero-based index of the currently selected item (returns `-1` if no item is selected).


* `SelectedItem`: Retrieves the actual object or text of the selected item.