# ThinkSharp Learning Concepts & FAQs

Welcome to the ThinkSharp Elementary Q n A guide.  
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

## Q: What is the difference between `int.Parse()` and `Convert.ToInt32()`?

### Explanation

- Both are used to convert values to `int`, but they behave differently when the input is `null` or not a string.

### `int.Parse(string)`

- Converts a valid numeric string to an integer.
- Only works with `string`.
- Throws:
  - `ArgumentNullException` if input is `null`.
  - `FormatException` if input is not a valid number.

```csharp
int x = int.Parse("123"); // returns 123
int y = int.Parse(null);  // ❌ throws ArgumentNullException
int z = int.Parse("abc"); // ❌ throws FormatException
```

### `Convert.ToInt32(object)`

- Can convert many types: `string`, `bool`, `null`, `double`, etc.
- Returns `0` for `null`.
- Throws `FormatException` for invalid strings.

```csharp
int a = Convert.ToInt32("123"); // returns 123
int b = Convert.ToInt32(null);  // returns 0
int c = Convert.ToInt32("abc"); // ❌ throws FormatException
```

### When to Use What?

- Use `int.Parse()` if you're *sure* the string is non-null and valid.
- Use `Convert.ToInt32()` for safer conversions, especially when input may be `null` or of different types.

### Analogy

- `int.Parse()` is like expecting a perfect answer and throwing a tantrum if it’s missing.
- `Convert.ToInt32()` is like being flexible — “No answer? I’ll assume it’s zero.”

## Q: What is the difference between `Convert.ToInt16()`, `ToInt32()`, and `ToInt64()`?

### Explanation

- These methods convert a value (like a string or number) into an integer of a specific size.
- All of them are part of the `System.Convert` class.
- The number in the name (`16`, `32`, `64`) refers to **how many bits of memory** are used to store the value.

### Summary Table

| Method              | Converts To | Size in Bits | C# Keyword | Value Range                    |
|---------------------|-------------|--------------|------------|--------------------------------|
| `Convert.ToInt16()` | 16-bit int  | 16           | `short`    | –32,768 to +32,767             |
| `Convert.ToInt32()` | 32-bit int  | 32           | `int`      | –2,147,483,648 to +2,147,483,647 |
| `Convert.ToInt64()` | 64-bit int  | 64           | `long`     | ±9,223,372,036,854,775,807     |

### Example

```csharp
short s = Convert.ToInt16("100");
int i = Convert.ToInt32("100000");
long l = Convert.ToInt64("100000000000");
```

- These convert a string to a number of the correct size.

### Use Case

- Use `ToInt16()` only when you are **sure** the number is small and memory matters.
- Use `ToInt32()` for normal integer work (default in C#).
- Use `ToInt64()` for very **large** numbers or IDs.

### Analogy

- It's like choosing a storage box:
  - `Int16` = small box
  - `Int32` = medium box
  - `Int64` = large box  
  Choose based on how big your number is.




