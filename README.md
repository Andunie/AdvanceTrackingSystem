# AdvancedTrackingSystem Project

**AdvancedTrackingSystem** is a cutting-edge web application designed for efficient tracking and management of resources, processes, or personnel. Built using modern technologies such as **Aspire.Net**, **MudBlazor**, **MS SQL**, and **API** integrations, it offers real-time tracking, dynamic data updates, and a user-friendly interface.

## Features

- **Real-Time Tracking:** Integrates with external APIs to fetch and display live data.
- **Data Visualization:** Leverages MudBlazor for clean and interactive data representation.
- **Database Management:** Efficient storage and retrieval using MS SQL Server.
- **Scalable Architecture:** Built with Aspire.Net for modularity and extensibility.
- **Customizable Workflows:** Adaptable to various tracking scenarios (e.g., logistics, inventory, workforce).

---

## Technologies Used

- **Backend:** Aspire.Net, Entity Framework Core
- **Frontend:** Blazor with MudBlazor components
- **Database:** Microsoft SQL Server
- **API Integration:** Supports real-time data updates
- **Other Tools:**
  - Dependency Injection
  - Swagger for API documentation

## Getting Started
  Prerequisites
  Ensure you have the following installed:

  .NET 8 SDK
  Microsoft SQL Server
  Visual Studio 2022 (or any compatible IDE)
  Postman (optional, for API testing)
  
## Installation
Clone the repository:
bash git clone https://github.com/yourusername/AdvanceTrackingSystem.git
Open the solution in Visual Studio.
Configure the connection string in appsettings.json:
    "ConnectionStrings": {
        "DefaultConnection": "Server=your_server;Database=your_database;Trusted_Connection=True;"
    }
## Apply database migrations:
  dotnet ef database update
## Run the project:
    Start the AdvanceTrackingSystem.ApiService project to launch the API.
    Start the AdvanceTrackingSystem.Web project for the frontend.
