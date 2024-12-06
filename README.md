# Accessing Undefined Member in C# Class

This repository demonstrates a common C# error: trying to access a class member that hasn't been declared.  The `bug.cs` file contains the erroneous code, while `bugSolution.cs` shows the corrected version.  The error results in a compile-time error, highlighting the importance of careful class member definition.

## How to Reproduce

1. Clone this repository.
2. Open `bug.cs` in a C# IDE (like Visual Studio).
3. Attempt to compile the code.  You will encounter a compiler error indicating that `MyOtherProperty` is undefined.