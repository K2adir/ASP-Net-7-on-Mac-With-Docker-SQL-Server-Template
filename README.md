# Hello Mac Users

Aren't you tired of Microsoft's lack of proper documentation for Mac users and how horrible the DX (Developer Experience) is?

I know I am. Here you can have my ready-to-go template.

## Project Setup

This template includes a predefined connection string in `appsettings.json` and utilizes Docker for database management.

### Docker Image

We use the Microsoft Azure SQL Edge Docker image, which can be found [here](https://hub.docker.com/_/microsoft-azure-sql-edge).

**Installation and Running:**

1. Install the Docker image from the provided link.
2. Run it on your machine. My instance is running at `Port 1433:1433`.

### Configuration Details

#### Connection String

If your local host is something other than `127.0.0.1`, you will need to make adjustments. Here’s an example of how to write it in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "MovieDbContext": "Server=tcp:127.0.0.1,1433;Database=NetDemo;MultipleActiveResultSets=true;User=sa;Password=Admin@123; TrustServerCertificate=true;"
  }
}
