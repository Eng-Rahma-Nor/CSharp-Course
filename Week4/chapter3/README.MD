Waan ka xumahay inaanad arkin! Faylalku waxay ku jiraan sanduuqa ama meesha ay ka muuqdaan faylalka la sameeyay ee ku dhex yaalla shaashaddaada (workspace files ama code editor-ka).

Haddii aadan si toos ah u arkeyn, waa kan qoraalkii oo dhan ee labada fayl (oo adigu aad koobi kartato ama halkaan ka akhrisan kartato):

---

### 1. `README.md` (Summary of Chapter 3)

# Chapter 3: Making Decisions

This chapter covers decision structures, logical operators, input validation, and advanced GUI controls in C#.

## Key Topics Covered:

* **Decision Structures**: `if`, `if-else`, nested `if`, and `if-else-if` statements.


* **Relational Operators**: `>`, `<`, `>=`, `<=`, `==`, `!=`.


* **Logical Operators**: `&&` (AND), `||` (OR), and `!` (NOT).


* **Boolean Variables & Flags**: Using `bool` types to track program states.


* **String Comparison**: Using `==` and `String.Compare` / `CompareTo`.


* **Exception Prevention**: Using `TryParse` methods to handle invalid user input safely.


* **Input Validation**: Ensuring entered data falls within logical boundaries.


* **GUI Controls**: Radio buttons, check boxes, and list boxes.


* **Multiple Selection**: The `switch` statement as an alternative to `if-else-if`.



---

### 2. `notes.md` (Detailed Concepts & Explanations)

# Chapter 3: Detailed Concept Notes

## 4.1 Decision Structures and the `if` Statement

* **Control Structure**: Controls the order of statement execution.


* **Sequence Structure**: Executes statements in sequential order.


* **Decision Structure (Selection Structure)**: Executes specific statements only when a given condition is true.


* **Single-Alternative `if` Statement**: Evaluates a Boolean expression; if true, the block of code inside executes.



## 4.2 The `if-else` Statement

* Provides two paths of execution: one path if the condition is `true`, and another alternative path (`else`) if it is `false`.



## 4.3 Nested Decision Structures & `if-else-if`

* **Nested `if**`: Placing an `if` statement inside another `if` statement to test multiple dependent conditions sequentially.


* **`if-else-if` Statement**: Evaluates a chain of conditions, ideal for grading scales or multi-tier decisions (e.g., A, B, C, D, F).



## 4.4 Logical Operators

* **`&&` (AND)**: Returns true only if **both** sub-expressions are true.


* **`||` (OR)**: Returns true if **at least one** sub-expression is true.


* **`!` (NOT)**: Reverses the Boolean value (true becomes false, false becomes true).



## 4.5 `bool` Variables and Flags

* A `bool` variable stores either `true` or `false`.


* **Flag**: A variable used to signal whether a specific condition exists in the program (e.g., `isGrandMaster = true`).



## 4.6 Comparing Strings

* Strings can be compared using relational operators like `==` and `!=`, or methods like `String.Compare()` and `.CompareTo()`.



## 4.7 Preventing Data Conversion Exceptions (`TryParse`)

* Instead of letting `int.Parse` or `double.Parse` crash the app on bad input, `TryParse` safely attempts conversion and returns a boolean value (`true` or `false`).


* Syntax: `dataType.TryParse(string input, out targetVariable)`.



## 4.8 Input Validation

* The process of inspecting user input to ensure it is logical and safe before using it in calculations (e.g., ensuring test scores are between 0 and 100).



## 4.9 Radio Buttons and Check Boxes

* **Radio Buttons**: Mutually exclusive choices; selecting one automatically deselects others in the same group.


* **Check Boxes**: Allow users to select multiple independent options simultaneously.


* **`Checked` Property**: A boolean property indicating whether the control is selected.



## 4.10 The `switch` Statement

* A multi-alternative decision structure that evaluates a single expression against multiple `case` values.


* Uses `break` to exit a case and an optional `default` section for unmatched values.



## 4.11 Introduction to List Boxes (`ListBox`)

* Displays a list of items where users can select one.


* **Key Properties**:
* `Items`: Collection of items in the list box.


* `Items.Add(obj)` / `Items.Remove(obj)` / `Items.RemoveAt(index)` / `Items.Clear()`: Methods to manage items.


* `SelectedIndex`: Returns the index of the selected item (returns `-1` if nothing is selected).


* `SelectedItem`: Returns the actual object/item selected.