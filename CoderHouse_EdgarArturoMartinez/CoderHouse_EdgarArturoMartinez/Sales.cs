namespace CoderHouse_EdgarArturoMartinez
{
    public class Sales
    {
        //Encapsulated fields
        private int _id;
        private string _comentarios;

        //Properties
        public int Id { get; set; }
        public string Comentarios { get; set; }

        //Default constructor
        public Sales()
        {
            _id = 0;
            _comentarios = String.Empty;
        }

        //Parametrized Constructor
        public Sales(int id, string comentarios)
        {
            this._id = id;
            this._comentarios = comentarios;
        }
    }


}
