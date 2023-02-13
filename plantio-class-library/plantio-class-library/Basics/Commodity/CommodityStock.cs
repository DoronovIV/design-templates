namespace PlantioClassLibrary.Basics.Commodity
{
    public class CommodityStock : ICloneable
    {

        #region State



        /// <inheritdoc cref="Packages"/>
        private Dictionary<CommodityPackage, int>? _packages;


        /// <inheritdoc cref="Piles"/>
        private List<CommodityMass>? _piles;



        /// <summary>
        /// The list of the packages next to their amount.
        /// <br />
        /// Список пакетов рядом с их кол-вом.
        /// </summary>
        public Dictionary<CommodityPackage, int>? Packages
        {
            get { return _packages; }
            set { _packages = value; }
        }


        /// <summary>
        /// The list of the piles of material.
        /// <br />
        /// Список масс материала.
        /// </summary>
        public List<CommodityMass>? Piles
        {
            get { return _piles; }
            set { _piles = value; }
        }



        #endregion State




        #region API


        public object Clone()
        {
            Dictionary<CommodityPackage, int>? packsCopy = new(Packages);
            List<CommodityMass>? massesCopy = new(Piles);

            CommodityStock result = new CommodityStock(packsCopy, massesCopy);
            return result;
        }


        #endregion API




        #region Construction



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public CommodityStock()
        {
            _packages = null;
            _piles = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public CommodityStock(Dictionary<CommodityPackage, int>? packages, List<CommodityMass>? piles)
        {
            Packages = packages;
            Piles = piles;
        }



        #endregion Construction


    }
}
