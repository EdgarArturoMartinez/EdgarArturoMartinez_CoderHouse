namespace CoderHouse_EdgarArturoMartinez
{
    public class User
    {
        //Encapsulated fields
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contrasena;
        private string _mail;

        //Properties to be get and set
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Mail { get; set; }


        //Default Constructor
        public User()
        {
            _id = 0;
            _nombre = String.Empty;
            _apellido = String.Empty;
            _nombreUsuario = String.Empty;
            _contrasena = String.Empty;
            _mail = String.Empty;
        }

        //Parametrized Constructor
        public User(int id, string nombre, string apellido, string nombreUsuario, string contrasena, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contrasena = contrasena;
            this._mail = mail;
        }
    }
}