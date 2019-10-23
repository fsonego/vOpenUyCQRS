### Setup
Follow these steps to get your development environment set up:

  1. Clone the repository
  2. At the root directory, restore required packages by running:
      ```
     dotnet restore
     ```
  3. Next, build the solution by running:
     ```
     dotnet build
     ```
  4. Next, within the `\Src\WebUI\ClientApp` directory, launch the front end by running:
      ```
     npm start
     ```
  5. Once the front end has started, within the `\Src\WebUI` directory, launch the back end by running:
     ```
	 dotnet run
	 ```
  5. Launch [https://localhost:44376/](http://localhost:44376/) in your browser to view the Web UI
  
  6. Launch [https://localhost:44376/api](http://localhost:44376/api) in your browser to view the API


If you need to regenerate the Northwind Traders TypeScript client (`Northwind.WebUI\ClientApp\src\app\northwind-traders-api.ts`) follow these steps:

  1. First, launch the application as per the above instructions
  2. Next, from the `vOpenUYCQRS.WebUI\ClientApp` directory, run:
     ```
	 nswag run
	 ```

This was previously managed by an MSBuild task, however NSwag.MSBuild has not yet been updated to support .NET Core 3. The MSBuild task will be re-enabled when this happens.

## Technologies
* .NET Core 3
* ASP.NET Core 3
* Entity Framework Core 3
* Angular 8

