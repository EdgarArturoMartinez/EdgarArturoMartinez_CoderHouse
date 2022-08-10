﻿namespace CoderHouse_EdgarArturoMartinez
{
    public class SoldProduct
    {
        //Encapsulated fields
        private int _id;
        private int _stock;
        private int _idProducto;        
        private int _idVenta;

        //Properties
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }        
        public int IdVenta { get; set; }

        //Default Constructor
        public SoldProduct()
        {
            _id = 0;
            _stock = 0;
            _idProducto = 0;            
            _idVenta = 0;
        }

        //Parametrized Constructor
        public SoldProduct(int id, int stock, int idProducto, int idVenta)
        {
            this._id = id;
            this._stock = stock;
            this._idProducto = idProducto;            
            this._idVenta = idVenta;
        }
    }
}