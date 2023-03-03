namespace PlantioClassLibrary.Basics.Volatile
{
    public class Rate : ICloneable
    {

        private int _value;


        private string? _verbose;



        public int Value 
        {
            get { return _value; }
            set { _value = value; }
        }


        public string? Verbose
        {
            get { return _verbose; }
            set { _verbose = value; }
        }



        public object Clone()
        {
            Rate result = new Rate(Value, Verbose);
            return result;
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public Rate()
        {
            _value = 0;
            _verbose = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public Rate(int value, string verbose)
        {
            _value = value;
            _verbose = verbose;
        }

    }
}
