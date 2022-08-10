//Calling NameSpace of the solution to allow instance to another Classes.
using CoderHouse_EdgarArturoMartinez;
using CoderHouse_EdgarArturoMartinez.Model;

//Welcome App Section
Console.WriteLine("**********************************************");
Console.WriteLine("    Welcome to Coder House C# Application     \n");



//CreateProduct();
//CreateUser();
//CreateSale();
//CreateSoldProduct();

//UpdateProduct();
//UpdateUser();
//UpdateSales();
//UpdateSoldProduct();


void UpdateSoldProduct()
{
    ListAllSoldProducts();
    Console.WriteLine("Please input Id Sold Product to modify information.");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New Sold Product Stock");
    int stock = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New ID Producto");
    int idProducto = Convert.ToInt32(Console.ReadLine());

    SoldProductHandler objSoldProductHandlerUpdate = new SoldProductHandler();

    try
    {
        objSoldProductHandlerUpdate.UpdateSoldProduct(id, stock, idProducto);
        Console.WriteLine($"Sold Product : {idProducto}, has been Modified succesfully. \n");
        ListAllSoldProducts();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

void UpdateSales()
{
    ListAllSales();
    Console.WriteLine("Please input Id Sale to modify information.");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New Sales Comment");
    string comentarios = Console.ReadLine();

    SalesHandler objSalesHandlerUpdate = new SalesHandler();

    try
    {
        objSalesHandlerUpdate.UpdateSale(id, comentarios);
        Console.WriteLine($"Sale: {comentarios}, has been Modified succesfully. \n");
        ListAllSales();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

void UpdateUser()
{
    ListAllUsers();
    Console.WriteLine("Please input Id User to modify information.");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New User First Name");
    string nombre = Console.ReadLine();
    Console.WriteLine("Please input New User Last Name");
    string apellido = Console.ReadLine();
    Console.WriteLine("Please input  New UserName");
    string nombreUsuario = Console.ReadLine();
    Console.WriteLine("Please input New User Password");
    string contrasena = Console.ReadLine();
    Console.WriteLine("Please input New User Email");
    string mail = Console.ReadLine();

    UserHandler objUserHandlerUpdate = new UserHandler();

    try
    {
        objUserHandlerUpdate.UpdateUser(id, nombre, apellido, nombreUsuario, contrasena, mail);
        Console.WriteLine($"User: {nombreUsuario}, has been Modified succesfully. \n");
        ListAllUsers();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}

void UpdateProduct()
{
    ListAllProducts();
    Console.WriteLine("Please input Id Product to modify information.");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New Product Description");
    string descripciones = Console.ReadLine();
    Console.WriteLine("Please input New Product Cost");
    double costo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please input  New Product Sales Price");
    double precioVenta = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please input New Product Stock");
    int stock = Convert.ToInt32(Console.ReadLine());

    ProductHandler objProductHandlerUpdate = new ProductHandler();

    try
    {
        objProductHandlerUpdate.UpdateProduct(id, descripciones, costo, precioVenta, stock);
        Console.WriteLine($"Product: {descripciones}, has been Modified succesfully. \n");
        ListAllProducts();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Update clause");
    }
}



void CreateProduct()
{
	Console.WriteLine("Please input Product Description");
	string descripciones = Console.ReadLine();
    Console.WriteLine("Please input Product Cost");
    double costo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please input Product Sales Price");
    double precioVenta = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please input Product Stock");
    int stock = Convert.ToInt32(Console.ReadLine());

    ProductHandler objProductHandlerInsert = new ProductHandler();

	try
	{
		objProductHandlerInsert.InsertProduct(descripciones, costo, precioVenta, stock);
		Console.WriteLine($"Product: {descripciones}, has been inserted succesfully. \n");
        ListAllProducts();
	}
	catch (Exception ex)
	{

		Console.WriteLine("There was an error executing Insert clause" );
	}
}

void CreateUser()
{
    Console.WriteLine("Please input User First Name");
    string nombre = Console.ReadLine();
    Console.WriteLine("Please input User Last Name");
    string apellido = Console.ReadLine();
    Console.WriteLine("Please input UserName");
    string nombreUsuario = Console.ReadLine();
    Console.WriteLine("Please input User Password");
    string contrasena = Console.ReadLine();
    Console.WriteLine("Please input User Email");
    string mail = Console.ReadLine();

    UserHandler objUserHandlerInsert = new UserHandler();

    try
    {
        objUserHandlerInsert.InsertUser(nombre, apellido, nombreUsuario, contrasena, mail);
        Console.WriteLine($"User: {nombreUsuario}, has been created succesfully. \n");
        ListAllUsers(); 
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Insert clause");
    }
}

void CreateSale()
{
    Console.WriteLine("Please input Sale Comments");
    string comentarios = Console.ReadLine();    

    SalesHandler objSalesHandlerInsert = new SalesHandler();

    try
    {
        objSalesHandlerInsert.InsertSale(comentarios);
        Console.WriteLine($"Sale with Comment: {comentarios}, has been inserted succesfully.\n");
        ListAllSales();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Insert clause");
    }
}

void CreateSoldProduct()
{
    Console.WriteLine("Please input SoldProduct Stock");
    int stock = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input Product Id");
    int idProducto = Convert.ToInt32(Console.ReadLine());    

    SoldProductHandler objSoldProductHandlerInsert = new SoldProductHandler();

    try
    {
        objSoldProductHandlerInsert.InsertSoldProduct(stock, idProducto);
        Console.WriteLine($"Sold Product Id: {idProducto}, has been inserted succesfully. \n");
        ListAllSoldProducts();
    }
    catch (Exception ex)
    {

        Console.WriteLine("There was an error executing Insert clause");
    }
}



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

void ListAllSoldProducts()
{
    //Get all SoldProduct table from SQL database
    Console.WriteLine("**** ***** ****");
    SoldProductHandler spHandler = new SoldProductHandler();
    spHandler.GetSoldProducts();
    Console.WriteLine("");
}

void ListAllSales()
{
    //Get all Sales table from SQL database
    Console.WriteLine("**** ***** ****");
    SalesHandler sHandler = new SalesHandler();
    sHandler.GetSales();
    Console.WriteLine("");
}



