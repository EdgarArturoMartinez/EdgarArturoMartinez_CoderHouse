using System.Data.SqlClient;

namespace CoderHouse_EdgarArturoMartinez.Model
{
    public class SalesHandler : DataBaseHandler
    {
        public void DeleteSale(int Id)
        {
            string query = "DELETE FROM Venta " +
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
        public void UpdateSale(int Id, string Comentarios)
        {
            string query = "UPDATE Venta " +
                "SET Comentarios = @comentarios " +
                "WHERE Id = @id";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", Id);
                sqlCommand.Parameters.AddWithValue("@comentarios", Comentarios);               

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
        public void InsertSale(string Comentarios)
        {
            string query = "INSERT INTO Venta" +
                "(Comentarios)" +
                "VALUES (@comentarios)";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@comentarios", Comentarios);
                
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
        public List<Sales> GetSales()
        {
            Console.WriteLine("***** Showing Venta Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Comentarios");
            List<Sales> salesList = new List<Sales>();
            string query = "SELECT Id, Comentarios FROM Venta";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Sales oSales = new Sales();
                        oSales.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        oSales.Comentarios = sqlDataReader["Comentarios"].ToString();
                        salesList.Add(oSales);
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }

            foreach (var item in salesList)
            {
                Console.WriteLine($"{item.Id}|      {item.Comentarios}");
            }

            return salesList;
        }
        public List<Sales> GetSalesById(int id)
        {
            Console.WriteLine("***** Showing Venta Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Comentarios");
            List<Sales> salesList = new List<Sales>();
            string query = "SELECT Id, Comentarios FROM Venta " +
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
                        Sales oSales = new Sales();
                        oSales.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        oSales.Comentarios = sqlDataReader["Comentarios"].ToString();
                        salesList.Add(oSales);
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }

            foreach (var item in salesList)
            {
                Console.WriteLine($"{item.Id}|      {item.Comentarios}");
            }

            return salesList;
        }
        public List<Sales> GetLastSale()
        {
            Console.WriteLine("***** Showing Venta Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Comentarios");
            List<Sales> salesList = new List<Sales>();
            string query = "SELECT Top(1) Id, Comentarios FROM Venta ORDER BY Id DESC";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Sales oSales = new Sales();
                        oSales.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        oSales.Comentarios = sqlDataReader["Comentarios"].ToString();
                        salesList.Add(oSales);
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }

            foreach (var item in salesList)
            {
                Console.WriteLine($"{item.Id}|      {item.Comentarios}");
            }

            return salesList;
        }
    }
}
