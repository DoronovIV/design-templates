using PlantioClassLibrary.Basics.Commodity;
using PlantioClassLibrary.Basics.Common;

namespace PlantioClassLibrary.Basics.Commodity
{
    public class CommodityPackage : AbstractCommodity
    {


        #region State


        /// <inheritdoc cref="CommodityType"/>
        private CommodityType? _commodityType;


        /// <inheritdoc cref="IsIncomplete"/>
        private bool _isIncomplete;




        /// <summary>
        /// 'True' - if the package was unsealed and some volume has already been taken from it, otherwise 'false'.
        /// <br />
        /// "True" - если пакет был распечатан и немного материала было уже использовано, иначе "false".
        /// </summary>
        public bool IsIncomplete
        {
            get { return _isIncomplete; }
            set { _isIncomplete = value; }
        }


        /// <summary>
        /// The type of the commodity contained in the package.
        /// <br />
        /// Тип сырья, хранимого в пакете.
        /// </summary>
        public CommodityType? CommodityType
        {
            get { return _commodityType; }
            set { _commodityType = value; }
        }



        #endregion State





        #region API



        public override object Clone()
        {
            CommodityPackage result = new CommodityPackage(IsIncomplete, (CommodityType)CommodityType.Clone(), BasicType, Volume, Mass, (Finance)Price.Clone());
            return result;
        }



        #endregion API





        #region Construction



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public CommodityPackage()
        {
            _isIncomplete = false;
            _commodityType = null;
            BasicType = BasicCommodityType.Unknown;
            Volume = 0.0;
            Mass = 0.0;
            Price = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public CommodityPackage(bool isIncomplete, CommodityType advancedType, BasicCommodityType basciType, double volume, double mass, Finance? price) : base()
        {
            _commodityType = advancedType;
            BasicType = basciType;
            _isIncomplete = isIncomplete;
            Volume = volume;
            Price = price;
        }



        #endregion Construction


    }
}