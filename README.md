# CollaberaTestTask

## Enhancements or Changes
Given more time, the following enhancements could be made:

- Error Handling: Improve error handling to provide more detailed feedback to the user in case of failures.
- Caching: Implement more robust caching mechanisms to reduce the number of requests to the Hacker News API and improve performance.
- Unit Tests: Add unit tests for service methods and controller actions to ensure code quality and reliability.
- Logging: Integrate a logging framework (e.g., Serilog or NLog) to provide better visibility into the application's runtime behavior.
- Pagination: Implement pagination for the best stories endpoint to manage large datasets and enhance performance.
- Deployment: Create deployment scripts or documentation for deploying the application to a cloud service like Azure or AWS.

## Description

This application is a RESTful API that retrieves the best stories from Hacker News. It uses ASP.NET Core with the following technologies:
- **C#**
- **Newtonsoft.Json** for JSON processing
- **HttpClient** for making HTTP requests to the Hacker News API
- **Swagger** for API documentation and testing

## Assumptions

- You have .NET 6 or later installed on your machine.
- You have a basic understanding of ASP.NET Core and RESTful API development.
- The application is designed to be run locally for testing and development purposes.
- The Hacker News API is available and accessible from your network.

## Getting Started

To run the application, follow these steps:

### Prerequisites

1. Install [.NET SDK](https://dotnet.microsoft.com/download) (version 6 or later).
2. Install a code editor or IDE (e.g., [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)).

### Clone the Repository

Clone the repository to your local machine:

```bash
git clone [https://github.com/alexndrhoncharenko/CollaberaTestTask.git]
cd CollaberaTestTask


