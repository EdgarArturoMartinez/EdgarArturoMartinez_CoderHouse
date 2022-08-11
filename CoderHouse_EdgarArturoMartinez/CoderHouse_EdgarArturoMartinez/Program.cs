//Calling NameSpace of the solution to allow instance to another Classes.
using CoderHouse_EdgarArturoMartinez;
using CoderHouse_EdgarArturoMartinez.Model;

//Welcome App Section
Console.WriteLine("**********************************************");
Console.WriteLine("    Welcome to Coder House C# Application     ");
Console.WriteLine("----------------------------------------------------\n");



bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

#region OPTIONS MENU

bool MainMenu()
{
    Console.WriteLine("\r\nChoose Module to execute CRUD Methods: ");
    Console.WriteLine("1.  Products");
    Console.WriteLine("2.  Users");
    Console.WriteLine("3.  Sales");
    Console.WriteLine("4.  Sold Product");
    Console.WriteLine("0.  Salir \n");
    int optionMainMenu = Convert.ToInt32(Console.ReadLine());
    switch (optionMainMenu)
    {
        case 0:
            return false;
        case 1:
            Console.WriteLine("\r\nChoose Method for PRODUCTS: ");
            Console.WriteLine("1.  List All Products");
            Console.WriteLine("2.  Create Products");
            Console.WriteLine("3.  Update Products");
            Console.WriteLine("4.  Delete Products \n");
            int optionMenuProduct = Convert.ToInt32(Console.ReadLine());
                if (optionMenuProduct == 1) { ListAllProducts(); }
                if (optionMenuProduct == 2) { CreateProduct(); }
                if (optionMenuProduct == 3) { UpdateProduct(); }
                if (optionMenuProduct == 4) { DeleteProduct(); }
            return true;
        case 2:
            Console.WriteLine("\r\nChoose Method for USERS: ");
            Console.WriteLine("1.  List All Users");
            Console.WriteLine("2.  Create Users");
            Console.WriteLine("3.  Update Users");
            Console.WriteLine("4.  Delete Users \n");
            int optionMenuUsers = Convert.ToInt32(Console.ReadLine());
                if (optionMenuUsers == 1) { ListAllUsers(); }
                if (optionMenuUsers == 2) { CreateUser(); }
                if (optionMenuUsers == 3) { UpdateUser(); }
                if (optionMenuUsers == 4) { DeleteUser(); }
            return true;
        case 3:
            Console.WriteLine("\r\nChoose Method for SALES: ");
            Console.WriteLine("1.  List All Sales");
            Console.WriteLine("2.  Create Sales");
            Console.WriteLine("3.  Update Sales");
            Console.WriteLine("4.  Delete Sales \n");
            int optionMenuSales = Convert.ToInt32(Console.ReadLine());
                if (optionMenuSales == 1) { ListAllSales(); }
                if (optionMenuSales == 2) { CreateSale(); }
                if (optionMenuSales == 3) { UpdateSales(); }
                if (optionMenuSales == 4) { DeleteSales(); }
            return true;
        case 4:
            Console.WriteLine("\r\nChoose Method for SOLD PRODUCTS: ");
            Console.WriteLine("1.  List All Sold Products");
            Console.WriteLine("2.  Create Sold Products");
            Console.WriteLine("3.  Update Sold Products");
            Console.WriteLine("4.  Delete Sold Products \n");
            int optionMenuSoldProducts = Convert.ToInt32(Console.ReadLine());
                if (optionMenuSoldProducts == 1) { ListAllSoldProducts(); }
                if (optionMenuSoldProducts == 2) { CreateSoldProduct(); }
                if (optionMenuSoldProducts == 3) { UpdateSoldProduct(); }
                if (optionMenuSoldProducts == 4) { DeleteSoldProduct(); }
            return true;
        default:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You have chosen an invalid Option.!!");
            return true;
    }
}

#endregion



#region Delete SQL Methods

void DeleteProduct()
{
    ListAllProducts();
    Console.WriteLine("Please input Id Product to Delete information. \n");
    int id = Convert.ToInt32(Console.ReadLine());

    ProductHandler objProductHandlerDelete = new ProductHandler();

    try
    {
        objProductHandlerDelete.DeleteProduct(id);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"Product: {id}, has been Deleted succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListAllProducts();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

void DeleteUser()
{
    ListAllUsers();
    Console.WriteLine("Please input Id User to Delete information. \n");
    int id = Convert.ToInt32(Console.ReadLine());

    UserHandler objUserHandlerDelete = new UserHandler();

    try
    {
        objUserHandlerDelete.DeleteUser(id);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"User: {id}, has been Deleted succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListAllUsers();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

void DeleteSoldProduct()
{
    ListAllSoldProducts();
    Console.WriteLine("Please input Id Sold Product to Delete information. \n");
    int id = Convert.ToInt32(Console.ReadLine());  

    SoldProductHandler objSoldProductHandlerDelete = new SoldProductHandler();

    try
    {
        objSoldProductHandlerDelete.DeleteSoldProduct(id);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"Sold Product : {id}, has been Deleted succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListAllSoldProducts();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Delete clause");
    }
}

void DeleteSales()
{
    ListAllSales();
    Console.WriteLine("Please input Id Sale to Delete information. \n");
    int id = Convert.ToInt32(Console.ReadLine());   

    SalesHandler objSalesHandlerDelete = new SalesHandler();

    try
    {
        objSalesHandlerDelete.DeleteSale(id);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine($"Sale: {id}, has been Deleted succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListAllSales();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

#endregion


#region Update SQL Methods

void UpdateProduct()
{
    ListAllProducts();
    Console.WriteLine("Please input Id Product to modify information. \n");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New Product Description \n");
    string descripciones = Console.ReadLine();
    Console.WriteLine("Please input New Product Cost \n");
    double costo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please input  New Product Sales Price \n");
    double precioVenta = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please input New Product Stock \n");
    int stock = Convert.ToInt32(Console.ReadLine());

    ProductHandler objProductHandlerUpdate = new ProductHandler();

    try
    {
        objProductHandlerUpdate.UpdateProduct(id, descripciones, costo, precioVenta, stock);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Product: {descripciones}, has been Modified succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListAllProductsById(id);
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

void UpdateUser()
{
    ListAllUsers();
    Console.WriteLine("Please input Id User to modify information. \n");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New User First Name \n");
    string nombre = Console.ReadLine();
    Console.WriteLine("Please input New User Last Name \n");
    string apellido = Console.ReadLine();
    Console.WriteLine("Please input  New UserName \n");
    string nombreUsuario = Console.ReadLine();
    Console.WriteLine("Please input New User Password \n");
    string contrasena = Console.ReadLine();
    Console.WriteLine("Please input New User Email \n");
    string mail = Console.ReadLine();

    UserHandler objUserHandlerUpdate = new UserHandler();

    try
    {
        objUserHandlerUpdate.UpdateUser(id, nombre, apellido, nombreUsuario, contrasena, mail);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"User: {nombreUsuario}, has been Modified succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListAllUsersById(id);
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

void UpdateSales()
{
    ListAllSales();
    Console.WriteLine("Please input Id Sale to modify information. \n");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New Sales Comment \n");
    string comentarios = Console.ReadLine();

    SalesHandler objSalesHandlerUpdate = new SalesHandler();

    try
    {
        objSalesHandlerUpdate.UpdateSale(id, comentarios);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Sale: {comentarios}, has been Modified succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListAllSalesById(id);
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

void UpdateSoldProduct()
{
    ListAllSoldProducts();
    Console.WriteLine("Please input Id Sold Product to modify information. \n");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New Sold Product Stock \n");
    int stock = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New ID Producto \n");
    int idProducto = Convert.ToInt32(Console.ReadLine());

    SoldProductHandler objSoldProductHandlerUpdate = new SoldProductHandler();

    try
    {
        objSoldProductHandlerUpdate.UpdateSoldProduct(id, stock, idProducto);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Sold Product : {idProducto}, has been Modified succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListAllSoldProductsById(id);
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

#endregion


#region Insert Into SQL Methods

void CreateProduct()
{
	Console.WriteLine("Please input Product Description \n");
	string descripciones = Console.ReadLine();
    Console.WriteLine("Please input Product Cost \n");
    double costo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please input Product Sales Price \n");
    double precioVenta = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please input Product Stock \n");
    int stock = Convert.ToInt32(Console.ReadLine());

    ProductHandler objProductHandlerInsert = new ProductHandler();

	try
	{
		objProductHandlerInsert.InsertProduct(descripciones, costo, precioVenta, stock);
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Product: {descripciones}, has been inserted succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListLastIdProduct();
	}
	catch (Exception ex)
	{

		Console.WriteLine("There was an error executing Insert clause" );
	}
}

void CreateUser()
{
    Console.WriteLine("Please input User First Name \n");
    string nombre = Console.ReadLine();
    Console.WriteLine("Please input User Last Name \n");
    string apellido = Console.ReadLine();
    Console.WriteLine("Please input UserName \n");
    string nombreUsuario = Console.ReadLine();
    Console.WriteLine("Please input User Password \n");
    string contrasena = Console.ReadLine();
    Console.WriteLine("Please input User Email \n");
    string mail = Console.ReadLine();

    UserHandler objUserHandlerInsert = new UserHandler();

    try
    {
        objUserHandlerInsert.InsertUser(nombre, apellido, nombreUsuario, contrasena, mail);
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"User: {nombreUsuario}, has been created succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListLastIdUser(); 
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Insert clause");
    }
}

void CreateSale()
{
    Console.WriteLine("Please input Sale Comments \n");
    string comentarios = Console.ReadLine();    

    SalesHandler objSalesHandlerInsert = new SalesHandler();

    try
    {
        objSalesHandlerInsert.InsertSale(comentarios);
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Sale with Comment: {comentarios}, has been inserted succesfully.\n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListLastIdSale();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Insert clause");
    }
}

void CreateSoldProduct()
{
    Console.WriteLine("Please input SoldProduct Stock \n");
    int stock = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input Product Id \n");
    int idProducto = Convert.ToInt32(Console.ReadLine());    

    SoldProductHandler objSoldProductHandlerInsert = new SoldProductHandler();

    try
    {
        objSoldProductHandlerInsert.InsertSoldProduct(stock, idProducto);
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"Sold Product Id: {idProducto}, has been inserted succesfully. \n");
        Console.BackgroundColor = ConsoleColor.Black;
        ListLastIdSoldProduct();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Insert clause");
    }
}

#endregion


#region Select All SQL Methods

void ListAllProducts()
{
    //Get all Product table from SQL database
    Console.WriteLine("**** ***** ****");
    ProductHandler objProductHandler = new ProductHandler();
    objProductHandler.GetProducts();
    Console.WriteLine("");
}

void ListAllUsers()
{
    //Get all Users table from SQL database
    Console.WriteLine("**** ***** ****");
    UserHandler objUserHandler = new UserHandler();
    objUserHandler.GetUsers();
    Console.WriteLine("");
}

void ListAllSales()
{
    //Get all Sales table from SQL database
    Console.WriteLine("**** ***** ****");
    SalesHandler objSalesHandler = new SalesHandler();
    objSalesHandler.GetSales();
    Console.WriteLine("");
}

void ListAllSoldProducts()
{
    //Get all SoldProduct table from SQL database
    Console.WriteLine("**** ***** ****");
    SoldProductHandler objSoldProductsHandler = new SoldProductHandler();
    objSoldProductsHandler.GetSoldProducts();
    Console.WriteLine("");
}

#endregion


#region SELECT By ID SQL Methods

void ListAllProductsById(int id)
{
    Console.WriteLine("**** ***** ****");
    ProductHandler objProductHandler = new ProductHandler();
    objProductHandler.GetProductsById(id);
    Console.WriteLine("");
}

void ListAllUsersById(int id)
{
    Console.WriteLine("**** ***** ****");
    UserHandler objUserHandler = new UserHandler();
    objUserHandler.GetUsersById(id);
    Console.WriteLine("");
}

void ListAllSalesById(int id)
{
    Console.WriteLine("**** ***** ****");
    SalesHandler objSalesHandler = new SalesHandler();
    objSalesHandler.GetSalesById(id);
    Console.WriteLine("");
}

void ListAllSoldProductsById(int id)
{
    Console.WriteLine("**** ***** ****");
    SoldProductHandler spHandler = new SoldProductHandler();
    spHandler.GetSoldProductsById(id);
    Console.WriteLine("");
}

#endregion


#region SELECT LAST ROW SQL Methods

void ListLastIdProduct()
{
    Console.WriteLine("**** ***** ****");
    ProductHandler objProductHandler = new ProductHandler();
    objProductHandler.GetLastProduct();
    Console.WriteLine("");
}

void ListLastIdUser()
{
    Console.WriteLine("**** ***** ****");
    UserHandler objUserHandler = new UserHandler();
    objUserHandler.GetLastUser();
    Console.WriteLine("");
}

void ListLastIdSale()
{
    Console.WriteLine("**** ***** ****");
    SalesHandler objSalesHandler = new SalesHandler();
    objSalesHandler.GetLastSale();
    Console.WriteLine("");
}

void ListLastIdSoldProduct()
{
    Console.WriteLine("**** ***** ****");
    SoldProductHandler objSoldProductHandler = new SoldProductHandler();
    objSoldProductHandler.GetLastIdSoldProducts();
    Console.WriteLine("");
}

#endregion


