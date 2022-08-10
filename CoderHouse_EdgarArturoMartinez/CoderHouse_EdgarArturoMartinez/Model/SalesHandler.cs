using System.Data.SqlClient;

namespace CoderHouse_EdgarArturoMartinez.Model
{
    public class SalesHandler : DataBaseHandler
    {
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
    }
}
