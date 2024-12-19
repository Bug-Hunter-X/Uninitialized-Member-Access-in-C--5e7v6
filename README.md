# Uninitialized Member Access in C# Example

This repository demonstrates a common error in C#: accessing class members before they've been properly initialized.  The `Bug.cs` file shows the problematic code.  The `BugSolution.cs` file provides a corrected version.

## The Problem

In the original code, the `MyProperty` member of the `ExampleClass` is not assigned a default value in the constructor. Accessing it in the `MyMethod` before assignment could lead to an unexpected value or even a runtime exception depending on the context.

## The Solution

The solution involves either providing a default value for `MyProperty` in the class declaration or initializing it explicitly in the constructor.