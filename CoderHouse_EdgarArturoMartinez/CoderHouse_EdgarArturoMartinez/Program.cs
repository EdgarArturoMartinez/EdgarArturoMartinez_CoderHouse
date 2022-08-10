//Calling NameSpace of the solution to allow instance to another Classes.
using CoderHouse_EdgarArturoMartinez;
using CoderHouse_EdgarArturoMartinez.Model;

//Welcome App Section
Console.WriteLine("**********************************************");
Console.WriteLine("    Welcome to Coder House C# Application     ");


//Get all Product table from SQL database
Console.WriteLine("**** ***** ****");
ProductHandler pHandler = new ProductHandler();
pHandler.GetProducts();
Console.WriteLine("");

//Get all Users table from SQL database
Console.WriteLine("**** ***** ****");
UserHandler uHandler = new UserHandler();
uHandler.GetUsers();
Console.WriteLine("");

//Get all SoldProduct table from SQL database
Console.WriteLine("**** ***** ****");
SoldProductHandler spHandler = new SoldProductHandler();
spHandler.GetSoldProducts();
Console.WriteLine("");


//Get all Sales table from SQL database
Console.WriteLine("**** ***** ****");
SalesHandler sHandler = new SalesHandler();
sHandler.GetSales();
Console.WriteLine("");



