# ISTM 415 - Capstone Project

<div id=introduction>
  For our capstone project in ISTM 415, we were tasked with creating a web application for a restaurant using the following technologies we had learned over the course of the semester:
  <br><br>
  <ul>
    <li>ASP.NET Core MVC</li>
    <li>SQL Server</li>
    <li>EntityFramework Core</li>
    <li>HTML5</li>
  </ul>
  
  The web application did not necessarily have to be aesthetically pleasing or include a fully developed front-end, as the primary exercise of the project was for groups to demonstrate their ability to create a functional web application that can handle and manage database tables. The requirements for the project were as follows:
  <br>
  <ol>
    <li>Create a database and at least five (5) tables to store information.</li>
    <li>Create Razor Views to view each table, with at least two (2) being editable.</li>
    <li>Create any models, views, and controllers necessary to support your Key Business Process.</li>
    <li>Prepare a final report detailing the Key Business Process, code documentation, and a team reflection.</li>
  </ol>

  Our group, consisting of myself (Tanner Croom) alongside classmates Eric Franks and Calum Furgal, created a web application for the fictional restaurant Aggieland Tex-Mex, located in Bryan, Texas and serving customers across the Bryan-College Station area. Aggieland Tex-Mex is known for their fantastic tex-mex food and low prices to entice the significant population of college students that reside in the area.
  
  Our web application for employees of Aggieland Tex-Mex contains a fully-functioning SQL Server back-end with support for adding, editing, and removing customers, employees, and inventory items, as well as support for initiating new sales, complete with proper inventory decrementing, price calculation, and referential integrity through cascading deletion of Orders and Order Details.
  
</div>

<hr>

<div id=instructions>
  <h3>How to Run This Application</h3>
  
  <p>First, <a href="https://github.com/tannercroom/istm415-aggieland-tex-mex/releases">download the latest release of this project</a>, then extract all files to a single location. In the <i>Team4</i> folder, open the file <i>Team4_Project.sln</i> in a recent version of Microsoft Visual Studio.</p>
	
  This web application was created in Microsoft Visual Studio 2019. Any recent version of Microsoft Visual Studio can be used to open and run this application. However, in order for the application to successfully build and have the shopping cart and ordering systems function properly, the following packages must be installed through the NuGet Package Manager (found in the menu bar under Tools > NuGet Package Manager > Manage NuGet Packages for Solution...):
  
  <ul>
    <li>Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore v3.1.22</li>
	  <li>Microsoft.AspNetCore.Identity.EntityFrameworkCore v3.1.22</li>
	  <li>Microsoft.AspNetCore.Identity.UI v3.1.22</li>
	  <li>Microsoft.EntityFrameworkCore.SqlServer v3.1.22</li>
	  <li>Microsoft.EntityFrameworkCore.Tools v3.1.22</li>
  </ul>
  
  Once installed, run the following in the Package Manager Console (found in the menu bar under Tools > NuGet Package Manager > Package Manager Console):
	
  <code>Update-Database ATMDB -context ATMContext</code>
  
  Once this is completed, the user can run the application by clicking the dropdown arrow next to "Start" then selecting "Team4_Project". The application will run in a separate window of the user's default web browser.
</div>
