using PlantioClassLibrary.Basics.Common;
using System.Collections.Generic;

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





        #region API



        public override object Clone()
        {
            CommodityMass result = new CommodityMass(new (CommodityTypes), Volume, Mass, BasicType, (Finance)Price.Clone());
            return result;
        }



        #endregion API





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
            Mass = 0;
            BasicType = BasicCommodityType.Unknown;
            Price = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public CommodityMass(List<CommodityType> advancedTypes, double approximateVolume, double mass, BasicCommodityType basicType) : this()
        {
            CommodityTypes = advancedTypes;
            Volume = approximateVolume;
            BasicType = basicType;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public CommodityMass(List<CommodityType> advancedTypes, double approximateVolume, double mass, BasicCommodityType basicType, Finance price) : this(advancedTypes, approximateVolume, mass, basicType)
        {
            Price = price;
        }



        #endregion Construction



    }
}
