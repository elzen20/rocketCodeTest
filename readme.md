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

The .gitignore file also ignores the launchSettings.json and appsettings.json, if you want to test the project locally do not hesitate to contact me through my email ceqc.quintero@gmail.com and I can share that to you. It does not contain sensitive information, but I decided to ignore those files in case this is part of the evaluation. 

I also attached to the email where I sent the required files needed to run this project, you can use the following paths:
/rocketCodeTest/rocketCodeTest.Api/appsettings.Development.json
/rocketCodeTest.Api/appsettings.json
/rocketCodeTest.Api/Properties/launchSettings.json

## Use the followin commands to restore packages and build:

### `dotnet restore`
### `dotnet build`

## How to Run the project? 
Go to the root of the project and from terminal use this command:

### `dotnet run --project rocketCodeTest.Api`
