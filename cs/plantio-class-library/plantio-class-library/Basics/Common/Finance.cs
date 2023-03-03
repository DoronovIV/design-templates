namespace PlantioClassLibrary.Basics.Common
{
    public class Finance : ICloneable
    {


        private decimal _amount;

        private Currency? _currency;


        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }


        public Currency? Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }



        public override string ToString()
        {
            return $"{Math.Round(Amount, 2)}{Currency?.Symbols}";
        }


        public object Clone()
        {
            Finance result = new Finance(Amount, (Currency)Currency.Clone());
            return result;
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public Finance()
        {
            _amount = 0;
            _currency = null;
        }


        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public Finance(decimal amount, Currency currency)
        {
            _amount = amount;
            _currency = currency;
        }


    }
}
