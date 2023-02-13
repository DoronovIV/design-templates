namespace PlantioClassLibrary.Basics.Common
{
    public class Currency
    {

        /// <inheritdoc cref="Code"/>
        private string? _code;

        /// <inheritdoc cref="Symbols"/>
        private string? _symbols;



        /// <summary>
        /// The code of the currency.
        /// <br />
        /// Код валюты.
        /// </summary>
        public string? Code
        {
            get { return _code; } 
            set { _code = value; }
        }



        /// <summary>
        /// The signes of the currency, e.g. '$', 'c$'.
        /// <br />
        /// Символы валюты, например "$", "c$".
        /// </summary>
        public string? Symbols
        {
            get { return _symbols; }
            set { _symbols = value; }
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public Currency()
        {
            _code = null;
            _symbols = null;
        }


        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public Currency(string code, string symbols)
        {
            _code = code;
            _symbols = symbols;
        }

    }
}
