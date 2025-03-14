# Contacts Management System
A simple Contacts Management System built with C# (.NET Framework) using Windows Forms and connected to a SQL Server Database via ADO.NET.
The application allows users to manage their contacts easily, including adding, editing, deleting, Filteration and searching for contacts.

## 📋 Project Description
This project is a desktop application designed to manage contact information. It demonstrates how to perform CRUD (Create, Read, Update, Delete) operations on a database using ADO.NET. The system provides a user-friendly interface to interact with the contact list.

## ✅ Features
#### Add new contacts with details:
###### First Name.
###### Last Name.
###### Phone Number
###### Email
###### Address
###### Date Of Birth
###### Image Path
#### Connect to SQL Server database using ADO.NET.
#### Edit and update existing contacts.
#### Delete contacts permanently.
#### Search for contacts dynamically by name or other fields.
#### Display all contacts in a table (DataGridView).
#### Filter data according to the user's preference

## 💻 Technologies Used
###### Programming Language: C#
###### Framework: .NET Framework (Windows Forms)
###### Database: SQL Server
###### Data Access: ADO.NET (SQLConnection, SQLCommand, SQLDataAdapter)
#### Concepts:
###### Object-Oriented Programming (OOP)
###### CRUD Operations

## ⚙️ How to Run the Project
###### Clone the repository:
`git clone https://github.com/ZiadMBakry/Contacts-Management.git`
###### Open the project using Visual Studio.
###### Set up the SQL Server Database:
1. Create a database (ContactsDB).
2. Create Countries Table
`pash
`CREATE TABLE Countries (
    CountryID INT PRIMARY KEY IDENTITY(1,1),
    CountryName NVARCHAR(50) NOT NULL,
    CountryCode NVARCHAR(10) NULL,
    CountryPhoneCode NVARCHAR(10) NULL
);`

Run the provided contacts.sql script to create the Contacts table.
Update connection string in App.config file to match your SQL Server settings.

Build and Run the project.

🔑 Database Table Structure
sql
Copy
Edit
CREATE TABLE Contacts (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(255)
);
🚀 Future Improvements
Add login and user authentication.
Add data validation and error handling.
Export contacts to CSV or Excel.
Add image upload (profile picture for contacts).
Move to Entity Framework for easier database handling.
🙌 Author
Name: Ziad Bakry
Contact: [Your Email or LinkedIn]
🌐 License
This project is licensed under the MIT License. See the LICENSE file for details.
