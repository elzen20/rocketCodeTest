# Rocket Code Challenge Backend

It requires to create an `appsettings.Development.json` file for making the Database Connection:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=mydatabase;User=usuario;Password=contraseña;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}

The .gitignore file also ignores the launchSettings.json and appsettings.json, if you want to test the project locally do not hesitate to contact me through my email ceqc.quintero@gmail.com.and I can share that to you. It does not contains sensible information but I decided to ignore those files in case this is part of the qualification. 
## Use the followin commands to restore packages and build:

### `dotnet restore`
### `dotnet build`

## How to Run the project? 
Go to the root of the project and from terminal use this command:

### `dotnet run --project rocketCodeTest.Api`
