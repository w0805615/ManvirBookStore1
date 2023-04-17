2023-03-02
1505
Assignmnet#2 in-class in the lab
3.1(out of support)
individual Account authentication
No Razor
Reviewed Areas folder

1506 - in Startup.cs on line 33
removed options for the default identity:
options => options.SignIn.RequireConfirmedAccount = true

1510
Tested the app...everything OK
Actions Items:
Modify the navigation
Update the Copyright ...from static to dynamic
make repository -public

1513
Upadted the Welcome message
tested
Reviewed the Route pattern in startup.cs

Created Github repository

2023-03-03
1515
Test the app...

1525
Created a README.md file in the github and pulled it to the VS2019

2023-03-09
1414
Choosed a Darkly theme from the bootswatch.com
Renamed the older bootstrap file 
Added new bootstrap.css in 
Lib > bootstrap > dist > css > bootstrap.css

Made changes in _Layout.cshtml
renamed bootstrap.min.css to bootstrap.css
nav class from navbar-light to navbar-dark to bg-primary
Line 23 remove text dark
added text-white-50 bg-primary to the footer

Now in _LoginPartial.cshtml
removed text-dark

1429
Tested the app 
It worked!

1451
Added a live date in the footer of the layout.cshtml page

1455
Modified a navigation 
at the place of home nav I added a Books link
which is currently empty because I havent created the database yet.

1505
Almost Done
just need to make my repository public from private

1539
Added additonal css and scripts links in the layout.cshtml

1903
Dropdown worked
some of the attributes were missing that is why it didn't show up 
But now everthing looks fine!
Moving on to the next step!

1519
Added new projects

2023-03-23
1502

Continue!
Moved the Data Folder and paste to .DataAccess project(Deleted the original)

1521
Install NuGet package
- Identity.EntityFrameworkCore

Modified namespace
Deleted all default Class1.cs in all projects

Moved Models to the ManvirBooks.Models project and deleted the original

1537
Added project References
Renamed Models folders to View Models
Updated the HomeController.cs

Done for now!
Continue Later!

1816
the error: The type or namespace name 'ApplicationDbContext' could not be found
Solved!

Successfully Run the Application

Updated Files:
Error.cshtml
startup.cs
HomeController.cs

1822
Created new class in Utility project and added project References to utility project as well as Data Access
Added new class Customer to the Areas folder
Updated Routes in Startup.cs
pattern: "{area:Customer}/{controller=Home}/{action=Index}/{id?}");

ERROR!! page is not responding

Solved the ERROR:
endpoints.MapAreaControllerRoute(
        name: "defaultArea",
        areaName: "Customer",
        pattern: "{controller=Home}/{action=Index}/{id?}");

1857 Everything looks GOOD!

1904
Added a new Admin area in Areas
Added the proper view files and delete the Data and Models folder
Deleted the controllers folder

Assignment 2 Part 1 DONE!

2023-03-24
1505
Assignment 2 Part 2 
Start!

Updated the Database name in appsettings.json
Database=ManvirBookStore

Added migrations
add-migration AddDefaultIdentityMigration (this is a wrong default project)
New migration file name= ManvirBookStore.DataAccess

MIGRATION FILES:
20230324192450_AddDefaultIdentityMigration.cs
20230327220200_AddCategoryToDb.cs

1551
ERROR!
update-database
Build failed

2023-03-27
1803
Error Solved!
by updating NuGet Packages

Checked the tables in SQl Server ObjectExplorer

1806
Added new class Category class in Models, Modified
Once again Run the migration and updated the database
Reviewed Updataed database in SQl Server ObjectExplorer

Everything Look fine!

1821
Added New folders in ManvirBooks.DataAccess
Repository > IRepository > IRepository.cs
Added New class : Repository.cs
Modifeid both the classes with the given instructions

2023-03-29
1315
Created the individual repositories for category:
CategoryRepository.cs
ICategoryRepository.cs
Modified 
Resolved Errors!


2023-03-30
1703
Added new Interface in IRepository folder
-ISP_Call.cs
installed Nuget packages for Dapper

1730
Implemented new class - SP_Call.cs in the Repository 
Modified according to intructions
Added using statements
NO ERRORS!

RUN THE PROJECT
SUCCESSFULL!

1803
Added a new interface UnitOfWork
Modified 

1830
Modified startup.cs in the ConfigurationServices method
NO ERRORS
PROJECT RUN!

2023-04-05
Started the project again
REASON: I was not able to see the new projects in the github so starting it again
As explained I saved the README.txt file for restarting the whole assignment 2

22:40
Completed the assignment till Assignment 2 Part 2.

2023-04-06
1643
Added a new MVC Controller-Empty inside Areas/Admin/Controller ="CategoryController.cs" and Modified
ERROR: IUnitOfWork not found
SOLVED!
made IUnitOfWork.cs interface public.
CategoryRepository

Addded a new RazorView in Category folder in Area/Admin/Views
Modified as given in Assignment 2 folder

1726
ERROR: 
System.NullReferenceException: 'Object reference not set to an instance of an object.'
db was null.

1840
Solved the error. there was error in the db in file SP_Call.cs    (db should be written _db)

2023-04-12
1304
Created a new link in navigation to add categories
Modified index.cshtml to add icons in the category section.

1342
Got an ERROR: Get have no definition in ICategoryRepositry.cs
Added :IRepository<Category> in the file
Error Solved!

Added a new Razor View in the Upsert 

1411
Created new RazorView in the Views>Shared
_EditAndBackToListButton.cshtml
_CreateAndBackToListButton.cshtml
Tried adding new cotegory but got another error
Still trying to figure that out

1920
SOLVED using statement was not correct


EVERYTHING WORKS GREAT NOW

Created a POST method in CategoryController.cs
Removed save method from CategoryRepository
Added save method in IUnitOfWork.cs 

Added a HTTPDelete in the CategoryController.cs
added delete method in category.js
Added delete function code in the CategoryController.cs

Found that there was GetAll() function was missing in CategoryController.cs So just added that according to the instructions.
Everything works perfect 
I can delete update and add new category without anty ERROR!
ASSIGNMENT 2 PART II COMPLETED!

2023-04-13
2041
ASSIGNMENT 2 PART III Starting
Added a class in Models folder named "CoverType.cs"
Modifying files
added migration
migration file names: 20230414195934_AddCoverTypeToDb

updated database
there is already an object named 'AspNetRoles' in the database
ERROR solved changed the name of database in appsettings.json and it worked

2023-04-14
1935
created a interface in IRepository named "ICoverTypeRepository.cs"
created a class in Repository named "CoverTypeRepository.cs"
involved the using statements to resolve any errors and extended classes and interfaces

1943

Modified two files UnitOfWork and IUnitOfWork
added  public ICoverTypeRepository CoverType { get; private set; } in UnitOfWork
added    ICoverTypeRepository CoverType { get; } in IUnitOfWork

Updated-database
\SUCCESSFULL!

2005
Created a new folder in Vieews named "CoverType"
added a new razor view in it caleed "Index.cshtml"
Then created a new js file named "covertype.js " and modified as given instructions

2018
Created a new Controller named "CoverTypeController.cs"
modified according to given instructions

added a new view named "Upsert.cshtml"

2059
Added a class in Models folder named "Product.cs"
Modifying file named ApplicationDbContext.cs

added migration
migration file names: 20230415010459_AddProductToDb
validation file timestamp: 20230417204011_addValidationToProduct

updated database

2114

created a interface in IRepository named "IProductRepository.cs"
created a class in Repository named "ProductRepository.cs"
Modified two files UnitOfWork and IUnitOfWork
added  public ICoverTypeRepository Product { get; private set; } in UnitOfWork
added    ICoverTypeRepository Product { get; } in IUnitOfWork

2146

Followed same instructions as Category to form the Product page And completed the assignmnet 2 part III section(2)
everthing looks good till now
no errors!

2023-04-17
1643
added validation migrations to the product.cs class in .Models project and set several fields required and then uppdated the databse succesfully.

1701
Created a new class in ViewModels folder in th e.Models project named "ProductVM.cs"
Modified according to the given instructiobns and installed the packaged to solve the error