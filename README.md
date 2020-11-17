# [Light Bootstrap Dashboard React .NET Core]

**Light Bootstrap Dashboard React .NET Core** is a fork of **[Light Bootstrap Dashboard React](https://demos.creative-tim.com/light-bootstrap-dashboard-react/#/?ref=lbdr-readme)** using [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1) infrastructure. This dashboard can be deployed without requiring Node.js to be installed on the server.

The dahboard is built on top of **React** project template that comes with ASP.NET Core

## Quick start

Quick start options:

- Clone the repo: `git clone https://github.com/smattoo/light-bootstrap-dashboard-react-net-core.git`.
- [Download from Github](https://github.com/smattoo/light-bootstrap-dashboard-react-net-core/archive/master.zip).
  

## Building the project
 
### Prerequisite
- The project requires follwing dependencies to be installed to generate a build:   
  - [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
  - [Node JS](https://nodejs.org/en/download/)

### Building the project on local system
- Set the following environment variables
    ```
    set ASPNETCORE_ENVIRONMENT=Development  
    set NODE_ENV=development 
    ```
- Generate the build using the command provided with .NET Core CLI.
    ```
    dotnet build
    ```
- Run the dashboard locally using the command
    ```
    dotnet run --debug
    ```

### Batteries included for development environment

- Integrated JSON server running on https://localhost:3000
  - Simulate a backend server and REST API with a simple json file. 
- Plus all the benefits of [**Light Bootstrap Dashboard React**](https://www.creative-tim.com/product/light-bootstrap-dashboard-react)
  

## Publish and Deploy
- Set the following environment variables for production build
    ```
    set ASPNETCORE_ENVIRONMENT=Production  
    set NODE_ENV=Production 
    ```
- Generate the build using the command provided with .NET Core CLI.
    ```
    dotnet publish -c release
    ``` 
- **Note:** The production build doesn't require Node.js to be installed on the server