# dotnet-core-api
Building API using ASP.NET CORE 2.2

Commands Using While Building API Project with ASP.NET CORE 2.2

-- Checking dotnet core Version --
 
 dotnet -version
 
 -- Creating Dot Net WEB API Core Project --
 
 new webapi -o DatingApp.API -n DatingApp.API
 
-- Running Dot net core Project --

 dotnet run
 
 dotnet watch run
 
  -- Building API using ASP.NET CORE --
 
 dotnet restore
 
-- Creating Code-First database Migration --
 
 Add-Migration "Initial"
 
 dotnet ef migrations add InitialCreates
 
 dotnet ef database update
