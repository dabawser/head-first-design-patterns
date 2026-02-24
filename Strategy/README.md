# Strategy Pattern

## Overview

The Strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## Key Concepts

- **Strategy**: An interface that defines a family of interchangeable algorithms
- **Concrete Strategy**: Implements the Strategy interface with a specific algorithm
- **Context**: Uses a Strategy to execute the algorithm

## Problem Solved

When you have multiple ways to perform a task and need to switch between them at runtime, the Strategy pattern avoids complex conditional logic by encapsulating each algorithm in its own class.

## Implementation

This folder contains a C# implementation of the Strategy pattern using .NET 10.

### Structure

- Strategy interface definitions
- Concrete strategy implementations
- Context class that uses strategies
- Console application demonstrating pattern usage
- xUnit tests validating behavior

## Example Usage

Define strategies for different behaviors, inject them into your context, and switch implementations without modifying client code.

## References

- *Head First Design Patterns* by Freeman & Robson
- [Strategy Pattern on SourceMaking](https://sourcemaking.com/design_patterns/strategy)
