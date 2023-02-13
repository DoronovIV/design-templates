namespace PlantioClassLibrary.Basics.Volatile
{
    public class TimeInterval
    {


        private int _min;


        private int _max;


        private string? _unit;



        public int Min 
        {
            get { return _min; }
            set { _min = value; }
        }


        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }


        public string? Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }


        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public TimeInterval()
        {
            _min = 0;
            _max = 0;
            _unit = null;
        }


        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public TimeInterval(int min, int max, string unit)
        {
            _min = min;
            _max = max;
            _unit = unit;
        }


    }
}
