using System.Collections.Generic;
using System.Data.SqlClient;

namespace CoderHouse_EdgarArturoMartinez.Model
{
    public class ProductHandler : DataBaseHandler
    {
        public List<Product> GetProducts()
        {
            Console.WriteLine("***** Showing Producto Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Descripciones|    Costo|  PrecioVenta|  Stock|  IdUsuario");
            List<Product> productsList = new List<Product>();
            string query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Product oProduct = new Product();
                        oProduct.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        oProduct.Descripciones = sqlDataReader["Descripciones"].ToString();
                        oProduct.Costo = Convert.ToDouble(sqlDataReader["Costo"]);
                        oProduct.PrecioVenta = Convert.ToDouble(sqlDataReader["PrecioVenta"]);
                        oProduct.Stock = Convert.ToInt32(sqlDataReader["Stock"]);
                        oProduct.IdUsuario = Convert.ToInt32(sqlDataReader["IdUsuario"]);
                        productsList.Add(oProduct); 
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {

                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }

            foreach (var item in productsList)
            {
                Console.WriteLine($"{item.Id}|  {item.Descripciones}|    {item.Costo}|  {item.PrecioVenta}|  {item.Stock}|  {item.IdUsuario}");
            }
            
            return productsList;         
        }

    }
}
