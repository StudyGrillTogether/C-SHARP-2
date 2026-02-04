# C# Fundamentals Learning Journey
---

## 📅 Day 1 – C# Type System and Variables

### 📘 Theory
- Strong typing in C#
- Value types vs Reference types
- Built-in types in C#
- Type conversion (implicit and explicit)

### 🧪 Practice
- Declare and convert different variable types
- Read user input safely
- Compare numeric data types

### 🛠 GitHub Exercise – **C#-TypesExplorer**
Create a console application that:
- Takes **name**, **age**, and **salary** as input from the user
- Calculates derived values
- Outputs formatted results based on the input

---

## 📅 Day 2 – Strings, Formatting, and DateTime

### 📘 Theory
- String immutability
- Common string APIs
- String interpolation
- DateTime operations and formatting

### 🧪 Practice
- Split full names
- Format dates
- Calculate age from date of birth

### 🛠 GitHub Exercise – **C#-StringDateUtilities**
Create a console application that:
- Accepts **full name** and **date of birth**
- Prints:
  - Initials
  - Age
  - Day of the week the user was born

---

## 📅 Day 3 – Collections (Arrays, Lists, Dictionaries, etc.)

### 📘 Theory
- Different collections available in C#/.NET
- Arrays vs `List<T>`
- Dictionaries: concept and usage
- Iteration patterns for collections
- Choosing the right collection for the right scenario

### 🧪 Practice
- Aggregate numeric data
- Count words in a sentence
- Search data in a dictionary

### 🛠 GitHub Exercise – **Collection Analyzer**
Create a console application that:
- Analyzes word frequency in a sentence
- Uses both **Lists** and **Dictionaries**
- Compares their usage and efficiency

---

## 📅 Day 4 – Exceptions and Error Handling

### 📘 Theory
1. What are exceptions?
2. Try / Catch / Finally blocks  
   - Usage  
   - Why they are needed  
   - How to use them
3. Common exception types
4. Validations and exceptions

### 🧪 Practice
1. Catch invalid input using exception handling
2. Throw exceptions intentionally
3. Create and throw a user-defined exception

### 💻 GitHub Exercise
**Exception Safe Calculator**
- Create a calculator application using exception handling
- Ensure the application is crash-proof

---

## 📅 Day 5 – File I/O and File Systems

### 📘 Theory
1. What is a file system in .NET?
2. Reading and writing files in C#
3. How paths are handled in code
4. Handling missing files
5. Types of files used in C# .NET

### 🧪 Practice
1. Save a text file using a console application
2. Append logs of a running application
3. Read a file on application startup

### 💻 GitHub Exercise
**File Based Notes App**
- Persistent notes application using text files

---

## 📅 Day 6 – Control Flow, Methods, and Enums

### 📘 Theory
1. If / Else If / Else
2. Switch statement (old and new way in C#)
3. Switch expressions (optional)
4. Nested conditions and why to avoid deep nesting
5. Method return types
6. Parameters vs local variables
7. Early returns
8. `out` vs `ref` and their usage
9. Breaking large logic into smaller methods
10. What are Enums
11. Why Enums are better than strings or numbers
12. Defining and using Enums
13. Casting Enums to and from `int`

### 🧪 Practice
1. Write a grading system  
   - Input score  
   - Output grade using `if/else` and `switch`
2. Extract logic into methods  
   - `CalculateGrade()`  
   - `PrintResult()`
3. Replace string statuses with Enums
4. Print Enum names and values

### 💻 GitHub Exercise
**Enums and Control Flow – Task Manager**
- Menu-driven console application
- Features:
  - Enum for task status: `Pending`, `InProgress`, `Completed`
  - Create tasks
  - Change task status
  - View tasks filtered by status
- Use:
  - `switch` for menu handling
  - Methods for each operation
  - Loops for task listing

---

## 📅 Day 7 – .NET CLI and Capstone Project

### 📘 Theory
1. What is the .NET SDK?
2. What are CLI commands?
3. Different build configurations
4. Standard .NET project structure

### 🧪 Practice
- Create a project using `.NET CLI`
- Inspect the `.csproj` file
- Build a Release version of the project

### 💻 GitHub Exercise – Capstone
**Console Utility Toolkit**

Create a menu-driven console application with the following features:

1. **Text Analyzer**
   - Total character count
   - Word count
   - Longest word
   - Uppercase version of the text  
   *(String and collection manipulation)*

2. **Number Statistics**
   - Accept numbers separated by commas
   - Display:
     - Count
     - Sum
     - Average
     - Minimum
     - Maximum

3. **Notes Manager**
   - File-based notes system

4. **Application Logs**
   - Store and append logs to files

---

## ✅ Goals
- Learn core C# fundamentals
- Understand exception handling and file systems
- Build structured, maintainable console applications
- Gain confidence with .NET CLI and project structure



