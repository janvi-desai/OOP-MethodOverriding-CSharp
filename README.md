# C# Method Overriding Test Cases

This repository contains **every possible test case** for method overriding and method hiding in **C#** using the keywords: `virtual`, `override`, and `new`.

## 📌 Purpose

To demonstrate **polymorphism** and the behavior of methods in base and derived classes using:
- `virtual` (for declaring an overridable method)
- `override` (for overriding a base class method)
- `new` (for method hiding, not true overriding)

---

## 🧪 Test Cases Included

- 🔹 Base class method only
- 🔹 Virtual method in base class, overridden in derived class
- 🔹 Virtual method in base class, hidden using `new` in derived class
- 🔹 Non-virtual method in base class, hidden using `new` in derived class
- 🔹 Multiple inheritance levels (Base → Derived → SubDerived)
- 🔹 Call methods using **base class reference** vs **derived class object**
- 🔹 Examples showing runtime vs compile-time behavior

---

## 🧠 Concepts Covered

- Polymorphism (Compile-time & Runtime)
- Inheritance
- Method Hiding vs Method Overriding
- Best practices for `virtual`, `override`, and `new`
- Output analysis to understand which method is called when

---

## 📁 Folder Structure

- `OverridingTests.cs`: Includes all test cases and detailed comments.
- Each test case prints the result of calling methods from base and derived class references.

---

## ✅ Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (any version that supports C# 7.0+)
- Visual Studio / VS Code / any C# IDE

---

## 🚀 Run the Code

```bash
git clone https://github.com/janvi-desai/OOP-MethodOverriding-CSharp.git
cd OOP-MethodOverriding-CSharp
dotnet run
```
---

### 👨‍💻 Author

**Janvi Desai(https://www.linkedin.com/in/janvi-desai-aa9b651b3/)**  
🧑‍💻 Around 3 years of experience in **ASP.NET** and **Angular**  
🎯 Passionate about **clean code**, **problem solving**, and **system design**

---

Feel free to fork and star ⭐ this repo if you find it helpful!
