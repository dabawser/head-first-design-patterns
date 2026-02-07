# Repository Copilot Instructions

## Project Overview

This repository contains the Head First Design Patterns solution, built with .NET.

## Folder Structure

- `/<pattern-name>/`: Each design pattern implementation should live in its own folder at the repository root. Create these folders as needed (`Strategy/`, `Observer/`, etc.).

## Libraries and Frameworks

- .NET 10 SDK
- Console applications for demonstration purposes
- StyleCop for C# code style enforcement
- xUnit for testing

## Coding Standards
- Place `using` directives outside namespaces.
- Order elements by kind, constant, accessibility, static, readonly.
- Allowed Hungarian prefix: `db`.
- Document interfaces; internal/private elements do not require XML docs.
- Use PascalCase for class, method, and property names.
- Use camelCase for local variables and parameters.
- Prefer explicit access modifiers.

## Testing Guidelines
- When adding tests, follow the naming and structure of any existing test projects in this repository.
- Keep tests close to the code they exercise (for example, in pattern-specific test projects or folders).

## Documentation

- Update `<pattern name>/README.md` for design pattern specific notes.

## Contribution Practices

- Adhere to coding standards and folder structure.
- Write tests for new patterns.
- Document public interfaces and APIs.
- Use pull requests for all changes; ensure CI passes before merging.
