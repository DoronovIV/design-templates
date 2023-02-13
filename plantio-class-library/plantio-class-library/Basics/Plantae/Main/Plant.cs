using PlantioClassLibrary.Basics.Common;
using PlantioClassLibrary.Basics.Volatile;
using PlantioClassLibrary.Basics.Plantae.Auxiliary;

namespace PlantioClassLibrary.Basics.Plantae.Main
{
    public abstract class Plant : ICloneable, ITradable
    {

        #region State


        /// <inheritdoc cref="Species"/>
        private Species? _species;


        /// <inheritdoc cref="PlantingMaterial"/>
        private IPlantingMaterial? _plantingMaterial;


        /// <inheritdoc cref="SoilNeedRatio"/>
        private double _soilNeedRatio;


        /// <inheritdoc cref="Rating"/>
        private PlantRating? _rating;         



        /// <summary>
        /// The biological species of the plant.
        /// <br />
        /// Биологический вид растения.
        /// </summary>
        public Species? Species
        {
            get { return _species; }
            set { _species = value; }
        }


        /// <summary>
        /// Type of the planting material of the species.
        /// <br />
        /// Тип посадочного материала для вида.
        /// </summary>
        public IPlantingMaterial? PlantingMaterial
        {
            get { return _plantingMaterial; }
            set { _plantingMaterial = value; }
        }


        /// <summary>
        /// The rate of soil required for growth.
        /// <br />
        /// Соотношение почвы, необходимое для выращивания.
        /// </summary>
        public double SoilNeedRatio
        {
            get { return _soilNeedRatio; }
            set { _soilNeedRatio = value; }
        }


        /// <summary>
        /// The set of ratings of a plant.
        /// <br />
        /// Набор характеристик растения.
        /// </summary>  
        public PlantRating? Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }


        public Finance? Price { get; set; }



        #endregion State



        #region API



        public abstract object Clone();



        #endregion API


    }
}
