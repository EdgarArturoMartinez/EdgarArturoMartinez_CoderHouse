namespace CoderHouse_EdgarArturoMartinez
{
    internal class Sales
    {
        //Encapsulated fields
        private int _id;
        private string _comments;

        //Properties
        public int Id { get; set; }
        public string Comments { get; set; }

        //Default constructor
        public Sales()
        {
            _id = 0;
            _comments = String.Empty;
        }

        //Parametrized Constructor
        public Sales(int id, string comments)
        {
            this._id = id;
            this._comments = comments;
        }
    }


}
