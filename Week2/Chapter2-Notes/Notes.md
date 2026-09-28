# Chapter 2 — Basic Elements & Variables

## Study Notes

These notes cover the beginning of **Chapter 2**, from the first assigned slides through **Variables**.


# 1. Structure of a Program

A basic program can be understood through three main stages:

```text
Input ? Processing ? Output
```

These three stages describe how information enters a program, how the computer works with that information, and how the result is produced.



# 2. Input

**Input** is the data provided to a computer or program.

Examples of input sources include:

* Keyboard
* Mouse
* Files
* Sensors
* Other devices

### Example

A user enters:

```text
20
```

The number `20` becomes input for the program.



# 3. Processing

**Processing** is the work performed by the computer on input data.

Processing may include:

* Calculations
* Comparisons
* Sorting
* Searching
* Data manipulation

### Example

```text
Input:
10 and 20

Processing:
10 + 20

Result:
30
```



# 4. Output

**Output** is the information or result produced by a program.

Examples include:

* Screen
* Printer
* File

### Example

```text
Input
  ?
10 + 20
  ?
Processing
  ?
Output
  ?
30
```



# 5. Data Types

A **data type** defines the kind of data that a variable can store.

Different types of information require different data types.

Common basic data types include:

* Integer
* Floating-point / Double
* Character
* String
* Boolean



# 6. Integer

An **integer** is a whole number without a decimal point.

### Examples

```text
10
-5
0
2024
```

In C#, the `int` data type is commonly used for integers.

### Example

```csharp
int age = 20;
```

Here:

* `int` ? data type
* `age` ? variable name
* `20` ? value


# 7. Floating-Point / Double

A floating-point number can contain a decimal value.

### Examples

```text
3.14
10.5
-0.01
```

In C#, `double` is commonly used for floating-point numbers.

### Example

```csharp
double price = 10.5;
```

Here:

* `double` ? data type
* `price` ? variable name
* `10.5` ? value


# 8. Character

A **character** represents a single character.

It can be:

* A letter
* A number
* A symbol

In C#, characters are written using **single quotation marks**.

### Examples

```text
'A'
'z'
'5'
'$'
```

### Example

```csharp
char grade = 'A';
```

The `char` data type stores one character.



# 9. String

A **string** is a sequence of characters used to represent text.

In C#, strings are written using **double quotation marks**.

### Examples

```text
"Hello World"
"Welcome"
"Programming"
```

### Example

```csharp
string name = "Ali";
```

Here:

* `string` ? data type
* `name` ? variable name
* `"Ali"` ? value


# 10. Boolean

A **Boolean** represents one of two possible values:

```text
true
false
```

In C#, the `bool` data type is used for Boolean values.

### Example

```csharp
bool isStudent = true;
```

Boolean values are commonly used in conditions and decision-making.



# 11. Variables

## What Is a Variable?

A **variable** is a named storage location used by a program to store data.

The value stored in a variable can change while the program is running.

### Example

```csharp
int age = 20;

age = 21;
```

Initially:

```text
age = 20
```

Later:

```text
age = 21
```

The variable name remains `age`, but the value changes.



# 12. Variables as Storage

A variable can be imagined as a labeled box that stores information.

```text
?????????????????
?      age      ?
?????????????????
?      20       ?
?????????????????
```

* `age` = variable name
* `20` = value stored in the variable



# 13. Variable Naming Rules

Variables must follow certain naming rules.



## Rule 1: Start with a Letter or Underscore

A variable name can start with:

* A letter (`A-Z` or `a-z`)
* An underscore (`_`)

### Valid

```csharp
age
studentName
_age
```



## Rule 2: Cannot Start with a Number

A variable name cannot begin with a number.

### Invalid

```csharp
1age
2students
```

### Valid

```csharp
age1
student2
```

Numbers can appear after the first character.



## Rule 3: No Spaces

Variable names cannot contain spaces.

### Invalid

```csharp
student name
```

### Valid

```csharp
studentName
```

or:

```csharp
student_name
```



## Rule 4: Do Not Use Reserved Keywords

Programming languages have special words called **keywords** or **reserved words**.

Examples include:

```text
int
if
class
public
while
```

These words have special meanings in C# and should not be used as variable names.



## Rule 5: Case Sensitivity

C# is **case-sensitive**.

This means uppercase and lowercase letters are treated differently.

### Example

```csharp
int age = 20;
int Age = 25;
```

`age` and `Age` are different variable names.



# 14. Variable Declaration

**Declaration** means specifying the data type and name of a variable.

### Example

```csharp
int age;
```

Here:

* `int` ? data type
* `age` ? variable name

The variable has been declared, but it has not been given an initial value.



# 15. Variable Initialization

**Initialization** means giving a variable its initial value.

### Example

```csharp
int age = 20;
```

Here:

* `int` ? data type
* `age` ? variable name
* `=` ? assignment operator
* `20` ? initial value



# 16. Declaration and Initialization Together

A variable can be declared and initialized in the same statement.

```csharp
int age = 20;
string name = "Ali";
double price = 10.5;
char grade = 'A';
bool isStudent = true;
```

Each statement creates a variable and gives it an initial value.



# 17. Changing a Variable's Value

A variable can receive a new value after initialization.

### Example

```csharp
int age = 20;

age = 21;
```

The value changes from `20` to `21`.



# ?? Chapter 2 Summary

| Term               | Meaning                              | Example         |
| ------------------ | ------------------------------------ | --------------- |
| **Input**          | Data provided to a program           | `20`            |
| **Processing**     | Work performed on data               | `10 + 20`       |
| **Output**         | Result produced by a program         | `30`            |
| **Integer**        | Whole number                         | `20`            |
| **Double**         | Decimal/floating-point number        | `10.5`          |
| **Character**      | Single character                     | `'A'`           |
| **String**         | Sequence of characters               | `"Hello"`       |
| **Boolean**        | `true` or `false`                    | `true`          |
| **Variable**       | Named storage location for data      | `int age = 20;` |
| **Declaration**    | Specifying type and variable name    | `int age;`      |
| **Initialization** | Giving a variable its initial value  | `age = 20;`     |
| **Keyword**        | Reserved word with a special meaning | `int`, `if`     |


# ?? Learning Objectives

After completing this section, I should be able to:

* Explain Input, Processing, and Output.
* Define a data type.
* Identify common C# data types.
* Explain integers.
* Explain floating-point numbers.
* Explain characters.
* Explain strings.
* Explain Boolean values.
* Define a variable.
* Explain variable naming rules.
* Understand case sensitivity.
* Declare variables.
* Initialize variables.
* Change the value of a variable.



# ?? Quick Review Questions

1. What is input?
2. What is processing?
3. What is output?
4. What is a data type?
5. What is an integer?
6. What is a double?
7. What does `char` store?
8. What is a string?
9. What values can a Boolean contain?
10. What is a variable?
11. What are the rules for naming variables?
12. What is variable declaration?
13. What is variable initialization?
14. What is the difference between `age` and `Age` in C#?
