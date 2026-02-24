# Observer Pattern

## Overview

The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. Observer lets you create loosely coupled event handling systems.

## Key Concepts

- **Subject**: Knows its observers and provides an interface for attaching and detaching observer objects
- **Observer**: Defines an interface for objects that should be notified of changes in a subject
- **Concrete Subject**: Stores state of interest to Concrete Observer objects and sends notifications to its observers when state changes
- **Concrete Observer**: Stores a reference to a Concrete Subject object and implements the Observer interface

## Problem Solved

When multiple objects need to react to state changes in another object, the Observer pattern eliminates tight coupling by allowing objects to subscribe to notifications rather than directly depending on each other.

## Implementation

This folder contains a C# implementation of the Observer pattern using .NET 10.

### Structure

- Observer interface definitions
- Subject interface definitions
- Concrete observer and subject implementations
- Console application demonstrating pattern usage
- xUnit tests validating behavior

## Example Usage

Create a subject, define observers that react to its state changes, and have the subject notify all registered observers when updates occur without tight coupling between components.

## References

- *Head First Design Patterns* by Freeman & Robson
- [Observer Pattern on SourceMaking](https://sourcemaking.com/design_patterns/observer)
