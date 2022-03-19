  <!--
________  ________ _______  ________ _______  _______  _______  _______    _______ ________ _________ _______ ________  _______ ________
|\     /||\     /|\__   __/\__   __/(  ____ \| \    /\(  ____ \(  ____ )  (  ____ \\__   __/|\     /|(  __  \ \__   __/(  ___  )(  ____ \
| )   ( || )   ( |   ) (      ) (   | (    \/|  \  / /| (    \/| (    )|  | (    \/   ) (   | )   ( || (  \  )   ) (   | (   ) || (    \/
| | _ | || (___) |   | |      | |   | (__    |  (_/ / | (__    | (____)|  | (_____    | |   | |   | || |   ) |   | |   | |   | || (_____ 
| |( )| ||  ___  |   | |      | |   |  __)   |   _ (  |  __)   |     __)  (_____  )   | |   | |   | || |   | |   | |   | |   | |(_____  )
| || || || (   ) |   | |      | |   | (      |  ( \ \ | (      | (\ (           ) |   | |   | |   | || |   ) |   | |   | |   | |      ) |
| () () || )   ( |___) (___   | |   | (____/\|  /  \ \| (____/\| ) \ \__  /\____) |   | |   | (___) || (__/  )___) (___| (___) |/\____) |
(_______)|/     \|\_______/   )_(   (_______/|_/    \/(_______/|/   \__/  \_______)   )_(   (_______)(______/ \_______/(_______)\_______)
                                                                                                                                        
 -->


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
Now is when we will want to check in SQL Server Object Explorer for the updated database MVCWineAPP. Go to tables check for User dbo and Wine dbo.<br>
  <strong> Close the application without Debugging window.</strong><br>
  
  <strong>Run IIS Express (Play button)</strong><br>
  If you do not have an accout you will have to register one with microsoft to use IIS Express.<br>
  
  This should run the application in a local hosted browser. Promting you to login, create username and password and it will allow entrance to the home page.<br>
  From here you can navigate to the Wine tab on the home page. This is where you will see where the wine anyone has entered is stored in the system.<br>
  If you click "create new wine" here you will find a seperate page that will allow you to enter in custom field for wine entry as well as a drop down list to select the wine type.<br>
  These wines are stored in our SQL database and then displayed on our "wine" page. Where you can Create, Read, Update, & Delete. (CRUD) <br>
  The login features for accounts was not initially in this application and scaffoleded in later on.<br>
  
Thank you for taking time for look over my project! I look forward to continuing to work on this as time goes on and fixing/Adding reworking different issues when I find I have More time..
  
  </ul><br>
<strong> &#9734; This project made possible by becuase of my loving wife.&hearts;&hearts;<br> Without her I would have never ventured into coding to begin with.</strong>
<ul>
  
