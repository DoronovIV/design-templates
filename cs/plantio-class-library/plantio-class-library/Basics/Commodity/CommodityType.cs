namespace PlantioClassLibrary.Basics.Commodity
{
    /// <summary>
    /// The type of the commodity. E.g. 'turf', 'dirt' etc.
    /// <br />
    /// Тип сырья. Например, "торф", "почва" и т.д.
    /// </summary>
    public class CommodityType : ICloneable
    {


        private string _name;



        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }



        public object Clone()
        {
            CommodityType result = new CommodityType(Name);
            return result;
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public CommodityType()
        {
            _name = string.Empty;
        }


        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public CommodityType(string name)
        {
            _name = name;
        }

    }
}
