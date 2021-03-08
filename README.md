# SGrade
## About
SGrade is a web service which allows students to grade courses, teachers and universities.

## Current state of project
The project is currently being in development.
Present implementation follows previous incomplete version of SGrade written solely in C# (.Net Core Razor Pages).
Decision on rewritting SGrade has been made due to lack of separation between server- and client-side which
created many architectural problems. 

### Technologies
The project seperates backend written in C# and frontend in ReactJS.
Backend is a  REST API created with the help of .Net Core 5.1. Additionaly it makes use of Entity Framework Core,
Automapper, IdentityServer and SQL Server. 
