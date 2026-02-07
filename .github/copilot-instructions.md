# Repository Copilot Instructions

## Project Overview

This repository contains the Head First Design Patterns solution, built with .NET.

## Folder Structure

- `/Strategy/`: Contains the implementation of the Strategy design pattern.
- `/<pattern name>/`: Other design patterns will be implemented in their respective folders.

## Libraries and Frameworks

- .NET 9 (see `global.json`)
- Console aplications for demonstration purposes
- StyleCop for C# code style enforcement
- xUnit for testing

## Coding Standards

- Follow StyleCop rules:
  - Place `using` directives outside namespaces.
  - Order elements by kind, constant, accessibility, static, readonly.
  - Allowed Hungarian prefix: `db`.
  - Document interfaces; internal/private elements do not require XML docs.
- Use PascalCase for class, method, and property names.
- Use camelCase for local variables and parameters.
- Prefer explicit access modifiers.

## Testing Guidelines

- Place unit tests in corresponding `*.UnitTests` projects.
- Use xUnit for all test projects.

## Documentation

- Update `<pattern name>/README.md` for design pattern specific notes.

## Contribution Practices

- Adhere to coding standards and folder structure.
- Write tests for new patterns.
- Document public interfaces and APIs.
- Use pull requests for all changes; ensure CI passes before merging.
