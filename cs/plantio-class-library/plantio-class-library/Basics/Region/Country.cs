namespace PlantioClassLibrary.Basics.Region
{
    public class Country
    {

        private string? _name;


        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public Country()
        {
            _name = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public Country(string name)
        {
            _name = name;
        }

    }
}
