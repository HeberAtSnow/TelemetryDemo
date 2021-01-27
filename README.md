# TelemetryDemo
The purpose of this demonstration project is for the Telemetry class at Snow College to have a starting environment.
Setup:
- 6 docker containers are defined in the .yml files
- 3 webapi 
- 1 postgres database
Serilog is being configured in this demo 2 different ways:
- appsettings.json (Facade service)
- Program.cs (Facade service)
Sinks are configured for postrges, console, and multiple files.

This is a 'look and learn' demo - not made for production use.

Learn and share!
-Heber
