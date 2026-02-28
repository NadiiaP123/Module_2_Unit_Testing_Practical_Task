# Number Of Characters Task (C#)

Console application developed using TDD aproach.

##  Task Description

The application provides methods for analyzing a string:
1. Count the maximum number of unequal consecutive characters.
2. Determine the maximum number of consecutive identical Latin letters.
3. Determine the maximum number of consecutive identical digits.

## Solution Structure

- **NumberOfCharactersTask/**  
  - `Program.cs` – console interaction with the user  
  - `NumberOfCharacters.cs` – methods for string processing  

  - **NumberOfCharactersTaskTests/**  
  - Contains unit tests for each method (MSTest)

  ## Testing

  Unit tests are implemented using **MSTest**.

  Unit tests follow AAA, FIRST principles, Equivalence partitioning, Boundary value analysis.

  Total tests: 45

  ## How to Run

  Build the solution:

    `dotnet build`

  Run tests:

    `dotnet test`

  ## Technologies

    C#
    .NET 10
    MSTest


       



