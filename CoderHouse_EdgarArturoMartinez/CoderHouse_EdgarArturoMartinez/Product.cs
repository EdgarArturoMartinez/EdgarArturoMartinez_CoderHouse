namespace CoderHouse_EdgarArturoMartinez
{
    internal class Product
    {
        //Encapsulated fields
        private int _id;
        private string _description;
        private double _price;
        private double _salesPrice;
        private bool _stock;
        private int _idUser;

        //Properties to be get and set
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Stock { get; set; }
        public int IdUser { get; set; }

        //Default Constructor
        public Product()
        {
            _id = 0;
            _description = String.Empty;
            _price = 0;
            _salesPrice = 0;
            _stock = false;
            _idUser = 0;
        }

        //Parametrized Constructor
        public Product(int id, string description, double price, double salesPrice, bool stock, int idUser)
        {
            this._id = id;
            this._description = description;
            this._price = price;
            this._salesPrice = salesPrice;
            this._stock = stock;
            this._idUser = idUser;
        }
    }
}