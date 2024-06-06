# TournamentTracker
## Overview
TournamentTracker is a robust application designed to manage and track tournaments. It consists of a .NET API and a WinForms application, allowing users to create tournaments, manage participants, track match results, and view standings. This application is perfect for organizers who want to streamline the tournament management process.

## Table of Contents
- Features
- Screenshots
- Getting Started
- Prerequisites
- Installation
- Usage
- API Documentation
- Technologies Used
- Domain Logic
- Known Issues
- Future Plans
- Contributing
- License
- Contact
- Acknowledgements
## Features
- Create Tournaments: Easily create and manage multiple tournaments.
- Participant Management: Add, remove, and edit participant information.
- Match Tracking: Record match results and track progress.
- Standings: Automatically calculate and display standings based on match results.
- User-friendly Interface: Intuitive and easy-to-navigate UI.
## Screenshots
### Dashboard
![Screenshot 2024-06-06 055449](https://github.com/sadegh15khedry/TournamentTracker/assets/90490848/dfcf9a32-73c1-4547-a23e-92f80f8f5beb)

### Create Tournament
![Screenshot 2024-06-06 060541](https://github.com/sadegh15khedry/TournamentTracker/assets/90490848/6a675bf8-5801-4de3-8d60-970bfefa2a8f)
### Manage Participants
![Screenshot 2024-06-06 060440](https://github.com/sadegh15khedry/TournamentTracker/assets/90490848/efd8725e-c102-4867-93b7-2be11d32a4be)


### Track Match Results
![Screenshot 2024-06-06 055630](https://github.com/sadegh15khedry/TournamentTracker/assets/90490848/36d72113-e90a-4fff-809b-6a5b6c20a0b1)

## Getting Started
### Prerequisites
.NET Core SDK (version 3.1 or higher)
SQL Server or other supported database systems
### Installation
#### Clone the repository:

bash
Copy code
```
git clone https://github.com/sadegh15khedry/TournamentTracker.git
cd TournamentTracker
```
#### Set up the database:

Update the appsettings.json file with your database connection string.
Run the SQL scripts in the SQLScripts directory to create the necessary database schema.
Build the API:

bash
Copy code
```
cd TournamentTracker.Api
dotnet build
```
#### Run the API:

bash
Copy code
```
dotnet run
```
Build the WinForms application:

bash
Copy code
```
cd ../TournamentTracker.WinForms
dotnet build
```
Run the WinForms application:

Open the TournamentTracker.WinForms/bin/Debug/netcoreapp3.1 directory and run the TournamentTracker.WinForms.exe file.
Usage
Create a new tournament:

Navigate to the "Create Tournament" section in the WinForms application.
Fill in the tournament details and add participants.
Manage participants:

Add new participants through the "Manage Participants" section.
Edit or remove existing participants as needed.
Track match results:

Record match results in the "Match Tracking" section.
View match history and standings.
API Documentation
For detailed information on how to interact with the .NET API, please refer to the API Documentation.

## Technologies Used
.NET Core
WinForms
SQL Server
Dapper (for ORM)
Refit (for API calls)
## Domain Logic
The domain logic of the application is encapsulated in the TournamentTrackerLibrary.


## Future Plans
- Implement a web-based frontend.
- Adding Form Validation
- Add support for more database systems.
- Enhance reporting and analytics features.
## Contributing
We welcome contributions! Please follow these steps:

Fork the repository.
Create a new branch (git checkout -b feature/YourFeature).
Commit your changes (git commit -m 'Add some feature').
Push to the branch (git push origin feature/YourFeature).
Create a new Pull Request.
## License
This project is licensed under the MIT License - see the LICENSE file for details.

## Contact
For questions or suggestions, feel free to open an issue or contact the project maintainers.

## Acknowledgements
Special thanks to Tim Corey for his YouTube course on the Tournament Tracker app, which served as the foundation for this project.
This project was expanded to a larger scale, including a .NET API for a multi-platform app design, to better suit the needs of a more complex tournament management system.
