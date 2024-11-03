
# ProductionSystem

ProductionSystem is a Blazor Web App developed to simulate the process of manufacturing a packaging machine. This project uses microservices within a single project structure, each service representing a different stage in the production process. It also demonstrates the use of dependency injection, DTOs, and Bootstrap for a responsive UI.

## Table of Contents

1. [Project Overview](#project-overview)
2. [Technologies Used](#technologies-used)
3. [Setup and Installation](#setup-and-installation)
4. [Project Structure](#project-structure)
5. [Usage](#usage)
6. [Additional Notes](#additional-notes)

## Project Overview

This application manages orders and tracks their progress through various manufacturing stages, including design, procurement, assembly, quality inspection, and shipping. Each stage is represented by an `OperationId` to demonstrate different steps in the production process.

## Technologies Used

- **Blazor Web App** (ASP.NET Core, .NET 8)
- **Dependency Injection** for service management
- **Bootstrap** for responsive UI components
- **C#** for backend service and DTOs

## Setup and Installation

### Prerequisites
- [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio or Visual Studio Code

### Steps to Set Up
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/ProductionSystem.git
   ```

2. Navigate to the project directory:
   ```bash
   cd ProductionSystem
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

6. Open a browser and navigate to:
   ```
   https://localhost:5001
   ```

## Project Structure

```
ProductionSystem/
│
├── Components/
│   └── Pages/
│       └── Home.razor          # Main page to view orders and stages
│
├── OrderService/
│   ├── OrderService.cs         # Contains OrderService logic to manage orders
│   └── OrderDTO.cs             # Defines the Order Data Transfer Object (DTO)
│
├── Program.cs                  # Configures services and app settings
└── README.md                   # Project documentation
```

### Key Files

- **OrderService.cs**: Handles business logic for creating and managing orders.
- **OrderDTO.cs**: Defines the structure of an order, including properties such as `Id`, `CustomerName`, `Product`, `Status`, and `OperationId`.
- **Home.razor**: The main Blazor component where orders and their manufacturing stages are displayed.

## Usage

1. **View Orders**:
   - On the `Home` page, you can view a list of orders along with their current stages in the production process.
   
2. **Operation Stages**:
   - Each order has an `OperationId` which represents its current stage in the production process.
   - Stages include:
     - **Design Phase**
     - **Material Procurement**
     - **Component Fabrication**
     - **Assembly**
     - **Quality Inspection**
     - **System Integration and Testing**
     - **Final Quality Assurance**
     - **Packaging and Preparation for Shipping**
     - **Dispatch and Delivery**

3. **Order Management**:
   - `OrderService` handles the order lifecycle, including creation, retrieval, and updating the current stage (`OperationId`).

## Additional Notes

- **Dependency Injection**: Ensure that `OrderService` is registered in `Program.cs` for injection in other components.
- **UI Styling**: Bootstrap is used for styling components in `Home.razor`. The table view of orders is responsive and styled with Bootstrap’s `table` classes.
- **Error Handling**: Common setup errors can include missing namespaces or services not registered in `Program.cs`. Make sure the structure and `using` directives are correct.
