# MVC CRUD Application with Three-Tier Architecture and Unit of Work Pattern

This project is an MVC application developed using .NET 5, following a three-tier architecture pattern. It implements the Unit of Work and Generic Repository design patterns to ensure efficient data management and separation of concerns.

## Table of Contents
- [Project Overview](#project-overview)
- [Architecture](#architecture)
- [Technologies Used](#technologies-used)
- [Features](#features)
- [Setup Instructions](#setup-instructions)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Project Overview
This application manages employees and departments, providing CRUD operations for both entities. It follows a three-tier architecture to separate data access, business logic, and presentation layers.

## Architecture
The project is divided into three main layers:
1. **Data Access Layer (DAL)**: Contains the EF Core DbContext, entity models, and repository implementations.
2. **Business Logic Layer (BLL)**: Contains business logic, the Unit of Work pattern implementation, and generic repository interfaces.
3. **Presentation Layer (PL)**: The ASP.NET Core MVC application that handles the user interface.

## Technologies Used
- .NET 5
- ASP.NET Core MVC
- Entity Framework Core
- AutoMapper
- Dependency Injection
- Unit of Work and Generic Repository Patterns
- SQL Server

## Features
- CRUD operations for Employees and Departments.
- Unit of Work pattern to manage transactions efficiently.
- AutoMapper for model-view model mapping.
- Generic repository for reusable data access logic.

## Setup Instructions

### Prerequisites
- .NET 5 SDK
- SQL Server

### Steps
1. **Clone the repository:**
   ```sh
   git clone https://github.com/Moemen99/MVC-CRUD-APP.git
   cd MVC-CRUD-APP
