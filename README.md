# AdoWebApiExample

An example of setting up a quick and easy configuration to get your connection string from appsettings.json to your repositories.

1. Create a Web Api Project in a new solution and select .NET 8 as the target framework.
2. Add a new Class Libary project to the solution and select .NET 8 as the target framework.
3. Add a project reference in the Web Api to reference your Class Library.
4. Set the Web Api as the startup project.
5. Add the following NuGet Packages to your Class Library  
 a. System.Data.SqlClient (latest version)  
 b. Microsoft.Extensions.Configuration (latest version)  
6. Add dependency injection for your configuration object.
7. Create a base repository and use depency injection to get an IConfiguration object.
8. Get your connection string and store it in a property in the base repository.
9. Create your repository and have it inherit from the base repository.
10. Add dependency injection for your repository (not the base one).
11. Add a method to your repository and use the connection string from the base repository.
12. Create your API endpoint that will correspond to your repository function and use dependency injection to get an instance of your repository (not the base repository).
13. Run the and use breakpoints and the locals window to verify your connection string is being read properly from appsettings.json.
14. Repeat steps 9-12 for any new repositories you create.
15. Repeat steps 11-12 for any new methods you create in an existing repository.
