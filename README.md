
# Head First Design Patterns

A comprehensive collection of design pattern implementations and exercises in C# using .NET.

## Overview

This repository contains practical examples of design patterns from the book *Head First Design Patterns*, implemented using modern .NET and C#.

## Repository Structure

Each design pattern lives in its own directory at the repository root:

```
/Strategy
/Observer
/Decorator
/Factory
...
```

Each pattern folder contains:
- Implementation examples
- Demonstration console applications
- Unit tests
- Pattern-specific README with notes and explanations

## Getting Started

### Prerequisites

- .NET 10 SDK

### Building

```bash
dotnet build
```

### Running Examples

Navigate to a pattern directory and run:

```bash
# From the repository root:
dotnet run --project Strategy/Strategy.csproj
```

### Running Tests

```bash
dotnet test
```

## Patterns Included

- Strategy
- Observer
- Decorator
- Factory
- *More coming soon...*

## Contributing

1. Follow the coding standards outlined in the contribution guidelines
2. Add tests for new patterns
3. Document public interfaces
4. Create a pull request against the main branch

## Code Standards

- C# coding conventions: PascalCase for types/methods, camelCase for variables
- xUnit for testing
- XML documentation for public APIs
