# Infestus Web App

## Config
- Edit server/app/appsettings.json or server/app/appsettings.Development.json to your liking

## Building

### Back-end
Ensure that .NET 8 is installed

- Navigate to server/
- Open server.sln if you are using Visual Studio
- Ensure that the app project is set as the startup project
- Build & Run

#### Database Migration (optional)
- Set the database project as the active project
- Run Add-Migration <XYZ> (if changes to the database schema were made)
- Run Update-Database to create / update the database

### Front-end
Ensure that node.JS v18.20.6 or higher is installed

- Navigate to client/
- npm install
- npm run dev (npm run build for prod)
- Ensure that the front-end points to the back-end url, open vite.config.js and verify the proxy setting

## Disclaimer
The Steam key auth logic requires a valid Steam API key, update the SteamApiKey appsetting to your api key.

## CI
[![Deploy on Linux](https://github.com/BerntA/InfestusWebApp/actions/workflows/deploy-linux.yml/badge.svg)](https://github.com/BerntA/InfestusWebApp/actions/workflows/deploy-linux.yml)
