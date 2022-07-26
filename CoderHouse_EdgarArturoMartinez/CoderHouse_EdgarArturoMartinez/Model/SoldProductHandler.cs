﻿using System.Data.SqlClient;

namespace CoderHouse_EdgarArturoMartinez.Model
{
    public class SoldProductHandler : DataBaseHandler
    {
        public void DeleteSoldProduct(int Id)
        {
            string query = "DELETE FROM ProductoVendido " +
                "WHERE Id = @id";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", Id);          

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
        public void UpdateSoldProduct(int Id, int Stock, int IdProducto)
        {
            string query = "UPDATE ProductoVendido " +
                "SET Stock = @stock, IdProducto = @idProducto " +
                "WHERE Id = @id";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", Id);                
                sqlCommand.Parameters.AddWithValue("@stock", Stock);
                sqlCommand.Parameters.AddWithValue("@idProducto", IdProducto);

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
        public void InsertSoldProduct(int Stock, int IdProducto)
        {
            string query = "INSERT INTO ProductoVendido" +
                "(Stock, IdProducto, IdVenta)" +
                "VALUES (@stock, @idProducto, 1)";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@stock", Stock);
                sqlCommand.Parameters.AddWithValue("@idProducto", IdProducto);                

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
        public List<SoldProduct> GetSoldProducts()
        {
            Console.WriteLine("***** Showing ProductVendido Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Stock|    IdProducto|  IdVenta");
            List<SoldProduct> soldProductList = new List<SoldProduct>();
            string query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        SoldProduct oSoldProduct = new SoldProduct();
                        oSoldProduct.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        oSoldProduct.Stock = Convert.ToInt32(sqlDataReader["Stock"]);
                        oSoldProduct.IdProducto = Convert.ToInt32(sqlDataReader["IdProducto"]);
                        oSoldProduct.IdVenta = Convert.ToInt32(sqlDataReader["IdVenta"]);

                        soldProductList.Add(oSoldProduct);
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }

            foreach (var item in soldProductList)
            {
                Console.WriteLine($"{item.Id}|      {item.Stock}|           {item.IdProducto}|           {item.IdVenta}");
            }

            return soldProductList;
        }
        public List<SoldProduct> GetSoldProductsById(int id)
        {
            Console.WriteLine("***** Showing ProductVendido Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Stock|    IdProducto|  IdVenta");
            List<SoldProduct> soldProductList = new List<SoldProduct>();
            string query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido " +
                "WHERE Id = @id;";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", id);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        SoldProduct oSoldProduct = new SoldProduct();
                        oSoldProduct.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        oSoldProduct.Stock = Convert.ToInt32(sqlDataReader["Stock"]);
                        oSoldProduct.IdProducto = Convert.ToInt32(sqlDataReader["IdProducto"]);
                        oSoldProduct.IdVenta = Convert.ToInt32(sqlDataReader["IdVenta"]);

                        soldProductList.Add(oSoldProduct);
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }

            foreach (var item in soldProductList)
            {
                Console.WriteLine($"{item.Id}|      {item.Stock}|           {item.IdProducto}|           {item.IdVenta}");
            }

            return soldProductList;
        }
        public List<SoldProduct> GetLastIdSoldProducts()
        {
            Console.WriteLine("***** Showing ProductVendido Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Stock|    IdProducto|  IdVenta");
            List<SoldProduct> soldProductList = new List<SoldProduct>();
            string query = "SELECT Top(1) Id, Stock, IdProducto, IdVenta FROM ProductoVendido ORDER BY Id DESC";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        SoldProduct oSoldProduct = new SoldProduct();
                        oSoldProduct.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        oSoldProduct.Stock = Convert.ToInt32(sqlDataReader["Stock"]);
                        oSoldProduct.IdProducto = Convert.ToInt32(sqlDataReader["IdProducto"]);
                        oSoldProduct.IdVenta = Convert.ToInt32(sqlDataReader["IdVenta"]);

                        soldProductList.Add(oSoldProduct);
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }

            foreach (var item in soldProductList)
            {
                Console.WriteLine($"{item.Id}|      {item.Stock}|           {item.IdProducto}|           {item.IdVenta}");
            }

            return soldProductList;
        }

    }
}
