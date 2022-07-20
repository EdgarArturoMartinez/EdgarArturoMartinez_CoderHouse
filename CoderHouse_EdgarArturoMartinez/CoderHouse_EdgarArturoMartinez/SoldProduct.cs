namespace CoderHouse_EdgarArturoMartinez
{
    internal class SoldProduct
    {
        //Encapsulated fields
        private int _id;
        private int _idProduct;
        private bool _stock;
        private int _idVenta;

        //Properties
        public int Id { get; set; }
        public int ProductId { get; set; }
        public bool Stock { get; set; }
        public int IdVenta { get; set; }

        //Default Constructor
        public SoldProduct()
        {
            _id = 0;
            _idProduct = 0;
            _stock = false;
            _idVenta = 0;
        }

        //Parametrized Constructor
        public SoldProduct(int id, int idProduct, bool stock, int idVenta)
        {
            this._id = id;
            this._idProduct = idProduct;
            this._stock = stock;
            this._idVenta = idVenta;
        }
    }
}