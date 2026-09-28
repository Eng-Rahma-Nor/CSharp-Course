# Chapter 1 — Programming Fundamentals

## Study Notes

These notes cover the remaining topics of **Chapter 1**, from the assigned slides through the end of the chapter.



# 1. Fundamentals of Programming

Programming is the process of writing instructions that tell a computer how to perform tasks and solve problems.

Programming languages have specific rules and meanings that programmers must follow.

Two important concepts are:

* **Syntax**
* **Semantics**



## 1.1 Syntax

**Syntax** refers to the rules and structure used to write code in a programming language.

It is similar to grammar in a human language. Just as English has grammar rules, programming languages have syntax rules.

If code does not follow the correct syntax, the program can produce a **Syntax Error**.

### Example

```csharp
int age = 20;
```

This follows the basic syntax for declaring and initializing an integer variable in C#.



## 1.2 Semantics

**Semantics** refers to the meaning or behavior of a program statement.

A program can have correct syntax but still produce an incorrect result because the logic is wrong.

This type of problem is commonly referred to as a **Logical Error**.

### Example

```csharp
int number1 = 10;
int number2 = 5;

int result = number1 - number2;
```

The syntax is correct.

However, if the intended operation was addition, the logic is incorrect.



# 2. Compilation and Interpretation

Source code must be processed so that a computer can execute the instructions.

Two important concepts are:

* Compiler
* Interpreter



## 2.1 Compiler

A **compiler** translates source code into another form that can be executed by the computer, typically before the program runs.

Examples of languages commonly associated with compilation include:

* C
* C++
* C#
* Java

### Basic Process

```text
Source Code
     ?
  Compiler
     ?
Executable / Intermediate Code
     ?
   Execute
```


## 2.2 Interpreter

An **interpreter** executes program instructions through runtime interpretation.

It is traditionally described as processing and executing instructions one at a time.

Examples commonly associated with interpreted execution include:

* Python
* JavaScript

### Basic Process

```text
Source Code
     ?
 Interpreter
     ?
 Execute
```

> **Note:** Modern programming languages may use a combination of compilation, interpretation, bytecode, and runtime technologies. The compiler/interpreter distinction is a simplified way to understand the basic concept.



# 3. Program Development Cycle

The **Program Development Cycle** describes the main stages involved in creating software.

The major stages are:

1. Problem Definition
2. Design
3. Coding
4. Testing and Debugging
5. Documentation and Maintenance



## 3.1 Problem Definition

**Problem Definition** means clearly identifying the problem that the program needs to solve.

Before writing code, the programmer should understand:

* What problem needs to be solved?
* What should the program do?
* What input is required?
* What output is expected?

### Example

Suppose we need to create a program that calculates the total price of two products.

The problem must first be clearly understood before designing the solution.

---

# 4. Design

The **Design** stage is where the programmer plans the solution.

The programmer determines how the problem will be solved before writing the actual code.

Common design tools include:

* Algorithms
* Pseudocode
* Flowcharts



# 5. Coding

**Coding** is the process of translating the designed solution into a programming language.

For example, a planned solution can be implemented using C#.

### Example

```csharp
int price1 = 10;
int price2 = 20;

int total = price1 + price2;
```

The code implements the solution planned during the design stage.



# 6. Testing and Debugging

## 6.1 Testing

**Testing** means running a program and checking whether it produces the expected results.

### Example

```text
Input:
10
20

Expected Output:
30
```

The programmer can test the program with different inputs to verify that it works correctly.



## 6.2 Debugging

**Debugging** is the process of finding and fixing errors in a program.

Errors in programs are commonly called **bugs**.

### Example

If the programmer intends to add two numbers but writes:

```csharp
int result = 10 - 20;
```

the logic needs to be corrected.

---

# 7. Documentation and Maintenance

## 7.1 Documentation

**Documentation** provides information about a program and explains how it works or how it should be used.

Documentation can include:

* Code comments
* User instructions
* Technical documentation
* Program descriptions
* README files

---

## 7.2 Maintenance

**Maintenance** involves updating and improving software after it has been developed.

Maintenance may include:

* Fixing bugs
* Adding features
* Updating the software
* Improving existing functionality
* Making required changes



# 8. Problem-Solving Tools

Programmers use different tools to plan and describe solutions before writing code.

The main tools are:

1. Algorithm
2. Pseudocode
3. Flowchart



# 9. Algorithm

An **algorithm** is a sequence of ordered steps used to solve a specific problem.

The steps should be clear and logically arranged.

### Example

Problem: Add two numbers.

```text
1. Start
2. Get the first number
3. Get the second number
4. Add the two numbers
5. Display the result
6. End
```

An algorithm focuses on the solution rather than the syntax of a specific programming language.



# 10. Pseudocode

**Pseudocode** is a way of describing program logic using simple, human-readable language.

It looks similar to programming code but does not follow the exact syntax of a programming language.

### Example

```text
START

INPUT number1
INPUT number2

sum = number1 + number2

OUTPUT sum

END
```

Pseudocode helps programmers organize their logic before writing actual code.


# 11. Flowchart

A **flowchart** is a visual representation of the steps involved in solving a problem or executing a program.

Common flowchart symbols include:

| Symbol        | Purpose        |
| ------------- | -------------- |
| Oval          | Start / End    |
| Rectangle     | Process        |
| Diamond       | Decision       |
| Parallelogram | Input / Output |
| Arrow         | Flow direction |

### Simple Example

```text
     Start
       ?
     Input
       ?
    Process
       ?
     Output
       ?
      End
```



# 12. Chapter 1 Summary

| Term              | Meaning                                               |
| ----------------- | ----------------------------------------------------- |
| **Syntax**        | Rules for writing code correctly                      |
| **Semantics**     | Meaning or behavior of code                           |
| **Compiler**      | Translates source code before or as part of execution |
| **Interpreter**   | Executes code through runtime interpretation          |
| **Algorithm**     | Ordered steps for solving a problem                   |
| **Pseudocode**    | Human-readable description of program logic           |
| **Flowchart**     | Visual representation of program logic                |
| **Testing**       | Checking whether a program works correctly            |
| **Debugging**     | Finding and fixing errors                             |
| **Documentation** | Information explaining a program                      |
| **Maintenance**   | Updating and improving software                       |



# ?? Learning Objectives

After completing this chapter, I should be able to:

* Explain basic programming concepts.
* Define syntax and semantics.
* Understand the basic difference between a compiler and an interpreter.
* Describe the Program Development Cycle.
* Explain problem definition and program design.
* Understand coding, testing, and debugging.
* Explain documentation and maintenance.
* Define an algorithm.
* Explain pseudocode.
* Explain flowcharts and their common symbols.
