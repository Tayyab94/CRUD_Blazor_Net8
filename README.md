# Blazor CRUD Application using Clean Architecture

Welcome to the Blazor CRUD Application repository! This project demonstrates a simple CRUD (Create, Read, Update, Delete) application implemented using Blazor, following the principles of Clean Architecture.

## Table of Contents
1. [Introduction](#introduction)
2. [Technologies Used](#technologies-used)
3. [Project Structure](#project-structure)
4. [Getting Started](#getting-started)
5. [Usage](#usage)
6. [Contributing](#contributing)
7. [License](#license)

## Introduction

This project showcases a Blazor application that performs CRUD operations using the Clean Architecture pattern. Clean Architecture ensures that the codebase is scalable, maintainable, and testable by separating concerns into different layers.

## Technologies Used

- **Blazor**: A framework for building interactive web UIs with C#.
- **Entity Framework Core**: An ORM for data access.
- **ASP.NET Core**: A cross-platform framework for building modern, cloud-based, Internet-connected applications.
- **Clean Architecture**: A software design pattern that divides the project into layers, promoting separation of concerns and making the system more maintainable and testable.

## Project Structure

The solution is divided into the following layers:

- **IMS.Plugins**: Contains the interfaces and their implementations for data access and other external services.
- **IMS.CoreBusiness**: Contains the business logic and domain entities.
- **IMS.UseCases**: Contains application-specific logic, including use cases, DTOs, and service interfaces.
- **IMS.WebApp**: The Blazor frontend application, which interacts with the UseCases layer.

```
IMS/
├── IMS.Plugins/
│   └── Interfaces/
│       └── IRepository.cs
├── IMS.CoreBusiness/
│   └── Entities/
│       └── Product.cs
├── IMS.UseCases/
│   └── UseCases/
│       └── ProductUseCases/
│           └── AddProductUseCase.cs
├── IMS.WebApp/
│   ├── Pages/
│   ├── wwwroot/
│   └── Program.cs
└── tests/
    ├── IMS.CoreBusiness.Tests/
    ├── IMS.UseCases.Tests/
    ├── IMS.Plugins.Tests/
    └── IMS.WebApp.Tests/
```

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository:**
   ```bash
 [  git clone https://github.com/yourusername/IMS.git](https://github.com/Tayyab94/CRUD_Blazor_Net8.git)
   cd IMS
   ```

2. **Restore the dependencies:**
   ```bash
   dotnet restore
   ```

3. **Update the database:**
   ```bash
   cd IMS.WebApp
   dotnet ef database update
   ```

### Running the Application

1. **Navigate to the WebApp project:**
   ```bash
   cd IMS.WebApp
   ```

2. **Run the application:**
   ```bash
   dotnet run
   ```

3. Open your browser and navigate to `https://localhost:5001` to see the application in action.

## Usage

- **Create**: Add new records using the provided form.
- **Read**: View existing records in the list.
- **Update**: Edit records by selecting them from the list and modifying the details.
- **Delete**: Remove records from the list.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a pull request.
Thank you for checking out the Blazor CRUD Application using Clean Architecture! If you have any questions or feedback, please feel free to open an issue or reach out. Happy coding!
