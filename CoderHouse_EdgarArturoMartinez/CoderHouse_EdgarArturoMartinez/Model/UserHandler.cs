using System.Data.SqlClient;

namespace CoderHouse_EdgarArturoMartinez.Model
{
    public class UserHandler : DataBaseHandler
    {
        public void DeleteUser(int Id)
        {
            string query = "DELETE FROM Usuario " +
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
        public List<User> GetUsersById(int id)
        {
            Console.WriteLine("***** Showing Usuario Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Nombre|    Apellido|  Nombre Usuario|  Contraseña|  Mail");
            List<User> userList = new List<User>();
            string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario " +
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
        public List<User> GetLastUser()
        {
            Console.WriteLine("***** Showing Usuario Table from SQL DataBase ***** \r\n");
            Console.WriteLine($"Id|   Nombre|    Apellido|  Nombre Usuario|  Contraseña|  Mail");
            List<User> userList = new List<User>();
            string query = "SELECT Top(1) Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario ORDER BY Id DESC";

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
        public bool GetUsersByUserName(string UserName, string Password)
        {            
            List<User> userList = new List<User>();
            string query = "SELECT Nombre FROM Usuario  " +
                "WHERE NombreUsuario = @userName AND Contraseña = @password; ";

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@userName", UserName);
                sqlCommand.Parameters.AddWithValue("@password", Password);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (!sqlDataReader.Read())
                    {
                        Console.WriteLine("User Name or Password are Incorrect, Impossible to Log In");   
                        return false;
                    }
                    while (sqlDataReader.Read())
                    {
                        User objUser = new User();
                        objUser.Contrasena = sqlDataReader["Nombre"].ToString();                        
                        userList.Add(objUser);
                    }
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }

                catch (Exception ex)
                {
                    throw new Exception("There is an error on query definition! " + ex.Message);
                }
            }           

            return true;
        }
    }
}
