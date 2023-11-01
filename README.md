# Super Hero API

API CRUD Application with .NET 7 and Entity Framework

In this project we see:
1. C#
2. .NET 7
3. Entity Framework
4. SQL Server
5. Dependency injection
6. Services Layer
7. Swagger

Step 1:
Install EF with this commands from package manager console:
1. dotnet ef (just for check)
2. dotnet tool install
3. dotnet tool update --global dotnet-ef

Step 2:
From the nuget package manager install:
   1. entityFrameworkCore
   2. entityFrameworkCore.Design
   3. entityFrameworkCore.SqlServer

Step 3:
Configure DBContext from DaraContext.cs

Step 4:
After configuring the DBContext from package manager make sure you are in the project directory folder
  1. dotnet ef migrations add InitialCreate
  2. dotnet ef database update

