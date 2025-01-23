# Multilayered Online Store Application

## Overview
The Multilayered Online Store Application is a .NET console application designed to simulate the operations of an online store. It features a robust architecture that includes data access, business logic, and presentation layers, ensuring a clean separation of concerns and maintainability.

## Features
- **User Roles:** Supports multiple user roles including Guest, Registered User, and Administrator.
- **Product Management:** Allows viewing, adding, updating, and deleting products.
- **Order Management:** Facilitates order creation, cancellation, and status tracking.
- **User Management:** Enables user registration, login, and management of user roles.
- **Multilayered Architecture:** Implements a clear separation between data access, business logic, and presentation layers.

## Technologies Used
- **.NET 8:** The application is built using the latest .NET framework.
- **Entity Framework Core:** For data access and ORM.
- **StyleCop:** For code style and quality analysis.
- **SOLID Principles:** Ensures a maintainable and scalable codebase.

## Project Structure
- **ConsoleApp:** Contains the main application logic and user interface.
- **Controllers:** Handles user input and application flow.
- **Handlers:** Manages specific tasks and operations.
- **Helpers:** Utility classes for common tasks.
- **MenuBuilder:** Constructs the menu system for different user roles.
- **MenuCore:** Core menu functionalities.
- **StoreBLL:** Business Logic Layer, contains services and models.
    - **Interfaces:** Defines contracts for services.
    - **Models:** Represents the data structures used in the application.
    - **Services:** Implements business logic.
- **StoreDAL:** Data Access Layer, manages database interactions.
    - **Data:** Contains database context and initialization logic.
    - **Entities:** Defines the database entities.

## Getting Started
1. **Clone the repository:**
     ```sh
     git clone https://github.com/yourusername/OnlineStore.git
     ```
2. **Build the project:**
     ```sh
     cd OnlineStore
     dotnet build
     ```
3. **Run the application:**
     ```sh
     dotnet run
     ```
