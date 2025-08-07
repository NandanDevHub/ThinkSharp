# ThinkSharp Learning Concepts & FAQs

Welcome to the ThinkSharp Concepts guide.  
This document contains explanations, examples, and answers to common programming questions encountered while learning C# and problem-solving.

## Q: Stack vs Heap

- **Stack**: Stores simple, short-lived data (value types).
- **Heap**: Stores complex, long-lived data (reference types).

### Value Types

- Examples: `int`, `bool`, `char`, `double`, `float`, `struct`
- Stored **directly** in Stack.
- Each variable has its own copy.
- Example:

  ```csharp
  int a = 10;
  int b = a;
  b = 20; // 'a' is still 10
  ```

### Reference Types

- Examples: `string`, `array`, `class`, `object`, `List<>`
- Stack stores a **reference (address)**.
- Actual data is stored in Heap.
- Multiple variables can point to the same data.
- Example:

  ```csharp
  string name1 = "John";
  string name2 = name1;
  name2 = "Mike"; // New string created; strings are immutable
  ```

### Analogy

- **Value Type** = You photocopy a document and hand it over.
- **Reference Type** = You give someone your locker key. They can open it and change the contents.

### Tip

- Use `ref` or `out` to pass **references** of value types if needed.
- Even strings (though reference types) behave like values because they are **immutable**.

---

## #What is `$`?

- `$` is used before a string to enable **string interpolation**.
- It allows you to embed variables or expressions directly inside the string using `{}`.

### Syntax Example

```csharp
string name = "Alice";
int age = 30;
Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
```

**Output:**
```
Hello, my name is Alice and I am 30 years old.
```

### Key Points

- Place `$` before the opening quote (`"`) of the string.
- Use `{variable}` or `{expression}` inside the string.
- It works with any data type that can be converted to string.

### Analogy

- Like a fill-in-the-blank sentence:
  - Template: `"Hello, {name}!"`
  - Fills in with actual value of `name` at runtime.




