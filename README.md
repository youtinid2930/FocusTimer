# ⏱️ FocusTimer

**FocusTimer** is a web application that helps users stay focused using the **Pomodoro technique** — a time management method that alternates work and break sessions. Built with **ASP.NET Core Razor Pages**, **JavaScript**, and **Bootstrap**, it also supports role-based user management (Patients, Doctors, Admins).

## 🎯 Features

- 🕒 25-minute work sessions with automatic 5-minute breaks
- ⏸ Pause and resume functionality
- 🔊 Sound notifications when timer ends
- 🧠 Task logging and history tracking
- 🧑‍⚕️ Role-based dashboard for Patients and Doctors
- 🔐 User registration and login with secure sessions
- 💾 Data stored with Entity Framework Core and SQL Server LocalDB

## 🖥️ Tech Stack

- **ASP.NET Core 8.0**
- **Razor Pages**
- **Entity Framework Core**
- **Bootstrap 5**
- **JavaScript / HTML / CSS**

## Usage

1. Clone the repo:
   navigate to your desired directory:
   ```bash
   git clone https://github.com/youtinid2930/FocusTimer.git
2. Install dependecies:
   ```bash
   cd FocusTimer
   dotnet restore
3. Setup Database:
   1. You can use Terminal:
      ```terminal
      dotnet tool install --global dotnet-ef
      dotnet ef database update
   2. Or navigate in VS to Tools>Nuget Package Manager> Package Manager Console:
       ```Nuget
       Update-Database
4. Run the application
   ```Terminal
   dotnet run

5. then go to https://localhost:5001
6. to view database use SQL Server Management:
   name user : (localdb)\MSSQLLocalDB , authentication : windows authentication
