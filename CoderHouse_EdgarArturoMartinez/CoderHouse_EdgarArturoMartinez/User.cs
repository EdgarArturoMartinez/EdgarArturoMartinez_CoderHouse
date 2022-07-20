namespace CoderHouse_EdgarArturoMartinez
{
    internal class User
    {
        //Encapsulated fields
        private int _id;
        private string _name;
        private string _lastName;
        private string _nameUser;
        private string _password;
        private string _email;

        //Properties to be get and set
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NameUser { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        //Default Constructor
        public User()
        {
            _id = 0;
            _name = String.Empty;
            _lastName = String.Empty;
            _nameUser = String.Empty;
            _password = String.Empty;
            _email = String.Empty;
        }

        //Parametrized Constructor
        public User(int id, string name, string lastName, string nameUser, string password, string email)
        {
            this._id = id;
            this._name = name;
            this._lastName = lastName;
            this._nameUser = nameUser;
            this._password = password;
            this._email = email;
        }
    }
}