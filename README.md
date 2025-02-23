# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  The code in `bug.cs` illustrates this scenario, while `bugSolution.cs` provides a corrected version.

## The Problem

In C#, properties, if not explicitly initialized, will have their default value (0 for ints, null for reference types, etc.).  However, relying on default values can lead to subtle bugs, especially if the default value isn't appropriate for the calculation.

## The Solution

The best way to prevent this issue is to explicitly initialize properties in the constructor, or set a default value directly in the property declaration.