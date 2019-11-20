# PhakeTwitter
Twitter-like clone made using asp.net mvc for Academy PGH

to migrate and update a local db file so you can use this repository, do the following commands in command line:
```
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

once those files have added, run the following two lines from the command line:
```
dotnet ef migrations add InitialCreate
dotnet ef database update
```
