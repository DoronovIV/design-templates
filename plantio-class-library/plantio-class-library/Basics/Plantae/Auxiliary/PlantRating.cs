using PlantioClassLibrary.Basics.Volatile;

namespace PlantioClassLibrary.Basics.Plantae.Auxiliary
{
    public class PlantRating : ICloneable
    {

        #region State


        private Rate? _fertilizerNeed;

        private Rate? _chemicalsNeed;

        private Rate? _selfloadRequired;

        private Rate? _verminExposure;   



        public Rate? FertilizerNeed
        {
            get { return _fertilizerNeed; }
            set { _fertilizerNeed = value; }
        }


        public Rate? ChemicalsNeed
        {
            get { return _chemicalsNeed; }
            set { _chemicalsNeed = value; }
        }


        public Rate? SelfloadRequired
        {
            get { return _selfloadRequired; }
            set { _selfloadRequired = value; }
        }


        public Rate? VerminExposure
        {
            get { return _verminExposure; }
            set { _verminExposure = value; }
        }

        #endregion State



        #region API



        public object Clone()
        {
            PlantRating result = new PlantRating((Rate)FertilizerNeed.Clone(), (Rate)ChemicalsNeed.Clone(), (Rate)SelfloadRequired.Clone(), (Rate)VerminExposure.Clone());
            return result;
        }



        #endregion API




        #region Construction



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public PlantRating()
        {
            _fertilizerNeed = null;
            _chemicalsNeed = null;
            _selfloadRequired = null;
            _verminExposure = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public PlantRating(Rate fertilizerNeed, Rate chemicalsNeed, Rate selfloadRequired, Rate verminExposure)
        {
            _fertilizerNeed = fertilizerNeed;
            _chemicalsNeed = chemicalsNeed;
            _selfloadRequired = selfloadRequired;
            _verminExposure = verminExposure;
        }


        #endregion Construction


    }
}
