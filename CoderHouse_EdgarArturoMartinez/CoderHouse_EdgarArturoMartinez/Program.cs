﻿//Calling NameSpace of the solution to allow instance to another Classes.
using CoderHouse_EdgarArturoMartinez;
using CoderHouse_EdgarArturoMartinez.Model;

//Welcome App Section
Console.WriteLine("**********************************************");
Console.WriteLine("    Welcome to Coder House C# Application     \n");



//CreateProduct();
//CreateUser();
//CreateSale();
//CreateSoldProduct();

//ListAllProducts();
//ListAllUsers();
//ListAllSales();
//ListAllSoldProducts();

//UpdateProduct();
//UpdateUser();
//UpdateSales();
//UpdateSoldProduct();

//DeleteProduct();
//DeleteUser();
//DeleteSales();
//DeleteSoldProduct();






#region Delete SQL Methods

void DeleteProduct()
{
    ListAllProducts();
    Console.WriteLine("Please input Id Product to Delete information.");
    int id = Convert.ToInt32(Console.ReadLine());

    ProductHandler objProductHandlerDelete = new ProductHandler();

    try
    {
        objProductHandlerDelete.DeleteProduct(id);
        Console.WriteLine($"Product: {id}, has been Deleted succesfully. \n");
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
    Console.WriteLine("Please input Id User to Delete information.");
    int id = Convert.ToInt32(Console.ReadLine());

    UserHandler objUserHandlerDelete = new UserHandler();

    try
    {
        objUserHandlerDelete.DeleteUser(id);
        Console.WriteLine($"User: {id}, has been Deleted succesfully. \n");
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
    Console.WriteLine("Please input Id Sold Product to Delete information.");
    int id = Convert.ToInt32(Console.ReadLine());  

    SoldProductHandler objSoldProductHandlerDelete = new SoldProductHandler();

    try
    {
        objSoldProductHandlerDelete.DeleteSoldProduct(id);
        Console.WriteLine($"Sold Product : {id}, has been Deleted succesfully. \n");
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
    Console.WriteLine("Please input Id Sale to Delete information.");
    int id = Convert.ToInt32(Console.ReadLine());   

    SalesHandler objSalesHandlerDelete = new SalesHandler();

    try
    {
        objSalesHandlerDelete.DeleteSale(id);
        Console.WriteLine($"Sale: {id}, has been Deleted succesfully. \n");
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
    Console.WriteLine("Please input Id Sale to modify information.");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please input New Sales Comment");
    string comentarios = Console.ReadLine();

    SalesHandler objSalesHandlerUpdate = new SalesHandler();

    try
    {
        objSalesHandlerUpdate.UpdateSale(id, comentarios);
        Console.WriteLine($"Sale: {comentarios}, has been Modified succesfully. \n");
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
        ListLastIdProduct();
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
        ListLastIdUser(); 
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
        ListLastIdSale();
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
    SalesHandler sHandler = new SalesHandler();
    sHandler.GetSales();
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


