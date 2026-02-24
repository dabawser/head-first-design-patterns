# Decorator Pattern

## Overview

The Decorator pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality. Decorator lets you add new features to objects without altering their structure.

## Key Concepts

- **Component**: An interface that defines objects to which additional responsibilities can be attached
- **Concrete Component**: The object to which additional responsibilities are attached
- **Decorator**: Maintains a reference to a Component object and defines an interface that conforms to Component's interface
- **Concrete Decorator**: Adds responsibilities to the component it decorates

## Problem Solved

When you need to add features to objects in flexible combinations, the Decorator pattern avoids an explosion of subclasses by allowing you to wrap objects with decorator instances at runtime.

## Implementation

This folder contains a C# implementation of the Decorator pattern using .NET 10.

### Structure

- Component interface definitions
- Concrete component implementations
- Decorator abstract class and concrete decorator implementations
- Console application demonstrating pattern usage
- xUnit tests validating behavior

## Example Usage

Create a base component, define decorators that wrap it and add behavior, and combine decorators at runtime to build objects with varying responsibilities.

## References

- *Head First Design Patterns* by Freeman & Robson
- [Decorator Pattern on SourceMaking](https://sourcemaking.com/design_patterns/decorator)
