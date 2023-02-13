namespace PlantioClassLibrary.Basics.Commodity
{
    public class CommodityMass : AbstractCommodity
    {



        #region State


        /// <inheritdoc cref="CommodityTypes"/>
        private List<CommodityType>? _commodityTypes;


        /// <summary>
        /// The list of the types of the mixed commodities.
        /// <br />
        /// Список типов смешанного сырья.
        /// </summary>
        public List<CommodityType>? CommodityTypes
        {
            get { return _commodityTypes; }
            set { _commodityTypes = value; }
        }


        #endregion State





        #region Construction



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public CommodityMass()
        {
            CommodityTypes = null;
            Volume = 0;
            BasicType = BasicCommodityType.Unknown;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public CommodityMass(List<CommodityType> advancedTypes, double approximateVolume, BasicCommodityType basicType)
        {
            CommodityTypes = advancedTypes;
            Volume = approximateVolume;
            BasicType = basicType;
        }



        #endregion Construction



    }
}
