# AcademyProsjekt

For å opprette roller, må du først laste inn `dbo.AspNetRoles.data.sql`.

1. Høyreklikk databasenavnet i Visual studio SQL server explorer og velg "New Query..."
2. Kopier inn innholdet fra filen `dbo.AspNetRoles.data.sql` og kjør spørringene

//For å kunne registrere bruker
//Åpne prosjektet i Visual Studio
//Åpne Package Manager Console i Visual Studio
//Skriv: update-database og trykk Enter
// Nå skal det fungere


//This app has a role based authorization connected to local database. This means that the users, roles, and all information related to security will be stored in a local SQL Server database. In this case, an instance of local DB running on the same development machine. 
//"admin" and "user" roles can be authorized read- and writepolicy.
//When you open project in VS, update-database in Package Manager Console to seed the different roles.
//Then, when you run the application and click on the “Role” link, you are asked to log in. Once logged in, you see the list of roles. You can also click Create to add a new role.
