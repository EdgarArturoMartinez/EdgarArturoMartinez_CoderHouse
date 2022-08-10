using System.Data.SqlClient;

namespace CoderHouse_EdgarArturoMartinez.Model
{
    public class UserHandler : DataBaseHandler
    {

        public void UpdateUser(int Id, string Nombre, string Apellido, string NombreUsuario, string Contrasena, string Mail)
        {
            string query = "UPDATE Usuario " +
                "SET Nombre = @nombre, Apellido = @apellido, NombreUsuario = @nombreUsuario, Contraseña = @contrasena, Mail = @mail " +
                "WHERE Id = @id";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", Id);
                sqlCommand.Parameters.AddWithValue("@nombre", Nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", Apellido);
                sqlCommand.Parameters.AddWithValue("@nombreUsuario", NombreUsuario);
                sqlCommand.Parameters.AddWithValue("@contrasena", Contrasena);
                sqlCommand.Parameters.AddWithValue("@mail", Mail);

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

        public void InsertUser(string Nombre, string Apellido, string NombreUsuario, string Contrasena, string Mail)
        {
            string query = "INSERT INTO Usuario" +
                "(Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
                "VALUES (@nombre, @apellido, @nombreUsuario, @contrasena, @mail)";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@nombre", Nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", Apellido);
                sqlCommand.Parameters.AddWithValue("@nombreUsuario", NombreUsuario);
                sqlCommand.Parameters.AddWithValue("@contrasena", Contrasena);
                sqlCommand.Parameters.AddWithValue("@mail", Mail);

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
        public List<User> GetUsers()
        {
            Console.WriteLine("***** Showing Usuario Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Nombre|    Apellido|  Nombre Usuario|  Contraseña|  Mail");
            List<User> userList = new List<User>();
            string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        User oUser = new User();
                        oUser.Id = Convert.ToInt32(sqlDataReader["Id"]);
                        oUser.Nombre = sqlDataReader["Nombre"].ToString();
                        oUser.Apellido = sqlDataReader["Apellido"].ToString();
                        oUser.NombreUsuario = sqlDataReader["NombreUsuario"].ToString();
                        oUser.Contrasena = sqlDataReader["Contraseña"].ToString();
                        oUser.Mail = sqlDataReader["Mail"].ToString();
                        userList.Add(oUser);
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }

            foreach (var item in userList)
            {
                Console.WriteLine($"{item.Id}|  {item.Nombre}|    {item.Apellido}|  {item.NombreUsuario}|  {item.Contrasena}|  {item.Mail}");
            }

            return userList;
        }
    }
}
