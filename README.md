# Connecting to Database with EntityFramework

## Step One Install EntityFramework and its Command Tool with the following commands

- Install EntityFramework run `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
- Installing EntityFramework Tools run `dotnet add package Microsoft.EntityFrameworkCore.Tools `
- To use the project with the Ef cli run `dotnet add package Microsoft.EntityFrameworkCore.Design`

- Now Add the EntityFramework cli tools to your system with this command :
  run `dotnet tool install --global dotnet-ef`

to test if your EF cli tools are working properly run the following command - `dotnet ef`

- finally Restore and build the project with the following commands
  - Restore packages run `dotnet restore` in the sln folder or the project folder
  - Build project run `dotnet build` in the sln or project folder

