# The Wine Rack
&#10070; Simple Wine Category Application 

&#10148; This application is my project submission for Code Kentucky spring class of 2022.

&#10148; This project is a simple ASP.NET EF Core wine storage/categorizing Web application that takes user input of wines they currently own.
Saves those inputs in a database then, displays them in on a crud page.

<br>
The live application is avaliable at http://thewinerack.azurewebsites.net/ hosted on Azure web services. Simply create a login(email) and password(numbers123and a symbol !@#$)
<br>
<br>

&#10070; This project was Created using Visual studio 2019 with .NET 5.0 and SQL<br>

<strong>Required Instructions to run local cloned repository:</strong><br>

<ul>Open Package Manager Console in Visual studio 2019.
<ul> Type> Entityframeworkcore\Enable-Migrations (this should error and require 2 contexts be added.)<br>
  Type> Entityframeworkcore\Enable-Migrations-Context AuthDbContext
    <br> >Name:Test (if required)<br>
  Type> Entityframeworkcore\Enable-Migrations-Context WineDBContext
    <br> >Name:Test1 (if required)<br>
  Type> Entityframeworkcore\Update-Database-Context AuthDbContext
  
<strong>Run the application without debugging.</strong><br></ul>
<br>
Now is when we will want to check in SQL Server Object Explorer for the updated database MVCWineAPP. Go to tables check for User dbo and Wine dbo. Close the application without Debugging window.
  
  </ul><br>
<strong> &#9734; This project should have the following list of working features in it:</strong>
<ul>
