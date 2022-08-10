using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CoderHouse_EdgarArturoMartinez.Model
{
    public class ProductHandler : DataBaseHandler
    {
        public void UpdateProduct(int Id, string Descripciones, double Costo, double PrecioVenta, int Stock)
        {
            string query = "UPDATE Producto " +
                "SET Descripciones = @descripciones, Costo = @costo, PrecioVenta = @precioVenta, Stock = @stock " +
                "WHERE Id = @id";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", Id);
                sqlCommand.Parameters.AddWithValue("@descripciones", Descripciones);
                sqlCommand.Parameters.AddWithValue("@costo", Costo);
                sqlCommand.Parameters.AddWithValue("@precioVenta", PrecioVenta);
                sqlCommand.Parameters.AddWithValue("@stock", Stock);                

                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {

                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }
        }

        public void InsertProduct(string Descripciones, double Costo, double PrecioVenta, int Stock)
        {
            string query = "INSERT INTO Producto" +
                "(Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" +
                "VALUES (@descripciones, @costo, @precioVenta, @stock, 1)";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@descripciones", Descripciones);
                sqlCommand.Parameters.AddWithValue("@costo", Costo);
                sqlCommand.Parameters.AddWithValue("@precioVenta", PrecioVenta);
                sqlCommand.Parameters.AddWithValue("@stock", Stock);

                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();                    
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {

                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }
        }

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
