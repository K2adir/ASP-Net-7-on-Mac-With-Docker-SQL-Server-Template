I just realized, I named the program as Net8, but it's Net 7. This is okay, follow the guide.

# Hello Mac Users

Aren't you tired of Microsoft's lack of proper documentation for Mac users and how horrible the DX (Developer Experience) is?

I know I am. Here you can have my ready-to-go template.

You only need 4 files from this repo.

Data/DbContext.cs

Program.cs, for this line
```
builder.Services.AddDbContext<MovieDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDbContext")));
```
Models/Movie.cs 

appsettings.json for the connection string setup.

## Project Setup

This template includes a predefined connection string in `appsettings.json` and utilizes Docker for database management.

### Docker Image

We use the Microsoft Azure SQL Edge Docker image, which can be found [here](https://hub.docker.com/_/microsoft-azure-sql-edge).

**Installation and Running:**

1. Install the Docker image from the provided link.
2. Run it on your machine. My instance is running at `Port 1433:1433`.
3. My docker image's Username (User=sa) and Password (Password=Admin@123) are written in the connection string. You may want to change it to something else. 

### Configuration Details

#### Connection String

If your local host is something other than `127.0.0.1`, you will need to make adjustments. Here’s an example of how to write it in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "MovieDbContext": "Server=tcp:127.0.0.1,1433;Database=NetDemo;MultipleActiveResultSets=true;User=sa;Password=Admin@123; TrustServerCertificate=true;"
  }
}

My file is included in the repo.
```

# Project Setup Instructions

## Initial Setup

After cloning the repository, open your terminal and execute the following command to install the missing NuGet packages:

```bash
dotnet restore
```

If this step fails, review the Data/DbContext and Program.cs files for any errors related to missing packages.

# Managing Database Migrations

Once the NuGet packages are restored, you can proceed with setting up and managing your database migrations using Entity Framework:

## Create a New Migration:

To create a new migration, run the following command in your terminal. Feel free to change "YourMigrationName"

```bash
dotnet ef migrations add YourMigrationName
```
## Update the Database:

Apply the latest migrations to update the database by running:
```bash
dotnet ef database update
```

Voala! (or something like that) check your database using Azure Data Studio,  [you can download it for free from Microsoft.](https://learn.microsoft.com/en-us/azure-data-studio/download-azure-data-studio?view=sql-server-ver16&tabs=win-install%2Cwin-user-install%2Credhat-install%2Cwindows-uninstall%2Credhat-uninstall).

For Azure Data Studio, use the following settings

Connection type: Microsoft sql server

input type: parameters 

server: localhost

username: sa (username of your running docker instance)

password: (docker password) 

trust server certificate: True

and hit connect. 
