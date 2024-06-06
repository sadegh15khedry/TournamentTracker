# TournamentTracker

## Overview

TournamentTracker is a robust application designed to manage and track tournaments. It consists of a .NET API and a WinForms application, allowing users to create tournaments, manage participants, track match results, and view standings. This application is perfect for organizers who want to streamline the tournament management process.

## Table of Contents

- [Features](#features)
- [Screenshots](#screenshots)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
    - [Clone the repository](#clone-the-repository)
    - [Set up the database](#set-up-the-database)
    - [Build the API](#build-the-api)
    - [Run the API](#run-the-api)
    - [Build the WinForms application](#build-the-winforms-application)
    - [Run the WinForms application](#run-the-winforms-application)
- [Usage](#usage)
- [API Documentation](#api-documentation)
- [Technologies Used](#technologies-used)
- [Domain Logic](#domain-logic)
- [Database](#database)
- [Known Issues](#known-issues)
- [Future Plans](#future-plans)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)
- [Acknowledgements](#acknowledgements)

## Features

- **Create Tournaments**: Easily create and manage multiple tournaments.
- **Participant Management**: Add, remove, and edit participant information.
- **Match Tracking**: Record match results and track progress.
- **Standings**: Automatically calculate and display standings based on match results.
- **User-friendly Interface**: Intuitive and easy-to-navigate UI.

## Screenshots

### Dashboard
![Screenshot 2024-06-06 055449](https://github.com/sadegh15khedry/TournamentTracker/assets/90490848/87aac98d-0131-4ac5-b366-9f0a024248d1)


### Create Tournament
![Screenshot 2024-06-06 060541](https://github.com/sadegh15khedry/TournamentTracker/assets/90490848/2caf3f22-9729-4177-9ebc-7229a9d6ddc2)


### Manage Participants
![Screenshot 2024-06-06 060440](https://github.com/sadegh15khedry/TournamentTracker/assets/90490848/5a20c92c-07ee-4d4b-90e4-12a897dc61ab)


### Track Match Results
![Screenshot 2024-06-06 055630](https://github.com/sadegh15khedry/TournamentTracker/assets/90490848/0355382b-c3b1-4b16-b492-81e501ba333b)



## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 3.1 or higher)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or other supported database systems

### Installation

#### Clone the repository

1. **Clone the repository:**
 ```bash
   git clone https://github.com/sadegh15khedry/TournamentTracker.git
   cd TournamentTracker
```

#### Set up the database

2. **Set up the database:**
   1. Use the sql server project included to generate the database.
   2. Update the `appsettings.json` file with your database connection string.

#### Build the API

3. **Build the API:**
 ```bash
   cd TournamentTracker.Api
   dotnet build
```
#### Run the API

4. **Run the API:**
```bash
   dotnet run
```
#### Build the WinForms application

5. **Build the WinForms application:**
```bash
   cd ../TournamentTracker.WinForms
   dotnet build
```
#### Run the WinForms application

6. **Run the WinForms application:**
   - Open the `TournamentTracker.WinForms/bin/Debug/netcoreapp3.1` directory and run the `TournamentTracker.WinForms.exe` file.

## Usage

1. **Create a new tournament:**
   - Navigate to the "Create Tournament" section in the WinForms application.
   - Fill in the tournament details and add participants.

2. **Manage participants:**
   - Add new participants through the "Tournament teams" section.
   - Edit or remove existing participants as needed.

3. **Track match results:**
   - Record match results in the "Match Tracking" section.
   - View match history and standings.

## API Documentation

API documention will be added in the futuer.

## Technologies Used

- .NET Core
- WinForms
- SQL Server
- Dapper (for ORM)
- Refit (for API calls)
- Visual Studio Database Project

## Domain Logic

The domain logic of the application is encapsulated in the `TournamentTrackerLibrary`.

## Database

- The database schema and interactions are defined using a Visual Studio Database Project.
- All database interactions are managed through stored procedures to ensure efficiency and security.


## Future Plans

- Implement a web-based frontend.
- Add support for more database systems.
- Enhance reporting and analytics features.

## Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Create a new Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For questions or suggestions, feel free to open an issue or contact the project maintainers.

## Acknowledgements

- Special thanks to Tim Corey for his YouTube course on the Tournament Tracker app, which served as the foundation for this project.
- This project was expanded to a larger scale, including a .NET API for a multi-platform app design, to better suit the needs of a more complex tournament management system.












