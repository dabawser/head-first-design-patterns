# Factory Pattern

## Overview

The Factory pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory lets a class defer instantiation to subclasses.

## Key Concepts

- **Creator**: Declares the factory method that returns a Product
- **Concrete Creator**: Implements the factory method to create Concrete Product instances
- **Product**: An interface that defines the type of objects the factory method creates
- **Concrete Product**: The class that implements the Product interface

## Problem Solved

When a class cannot anticipate the type of objects it needs to create, the Factory pattern encapsulates object creation logic, reducing coupling and allowing clients to work with objects through interfaces rather than concrete classes.

## Implementation

This folder contains a C# implementation of the Factory pattern using .NET 10.

### Structure

- Product interface definitions
- Concrete product implementations
- Creator abstract class and concrete creator implementations
- Console application demonstrating pattern usage
- xUnit tests validating behavior

## Example Usage

Define a factory method in a creator class, implement it in concrete creators to instantiate specific products, and let clients use the factory to obtain objects without knowing their concrete types.

## References

- *Head First Design Patterns* by Freeman & Robson
- [Factory Pattern on SourceMaking](https://sourcemaking.com/design_patterns/factory_method)
