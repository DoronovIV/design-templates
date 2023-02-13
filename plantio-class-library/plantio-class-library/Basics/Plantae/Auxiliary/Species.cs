namespace PlantioClassLibrary.Basics.Plantae.Auxiliary
{
    public class Species : ICloneable
    {


        #region State


        private string? _name;


        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }


        #endregion State



        #region API


        public object Clone()
        {
            Species result = new(Name);
            return result;
        }


        #endregion API



        #region Construction



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public Species()
        {
            _name = null;
        }


        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public Species(string name)
        {
            _name = name;
        }


        #endregion Construction


    }
}
