namespace CoderHouse_EdgarArturoMartinez
{
    public class Product
    {
        //Encapsulated fields
        private int _id;
        private string _descripciones;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsusario;

        //Properties to be get and set
        public int Id { get; set; }
        public string Descripciones { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        //Default Constructor
        public Product()
        {
            _id = 0;
            _descripciones = String.Empty;
            _costo = 0;
            _precioVenta = 0;
            _stock = 0;
            _idUsusario = 0;
        }

        //Parametrized Constructor
        public Product(int id, string descripciones, double costo, double precioVenta, int stock, int idUsuario)
        {
            this._id = id;
            this._descripciones = descripciones;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
            this._idUsusario = idUsuario;
        }
    }
}