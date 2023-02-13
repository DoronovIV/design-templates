using PlantioClassLibrary.Basics.Common;
using PlantioClassLibrary.Basics.Plantae.Auxiliary;
using System.Diagnostics;

namespace PlantioClassLibrary.Basics.Plantae.Main
{
    public class Flower : Plant
    {


        #region API


        public override object Clone()
        {
            Flower result = new Flower((Species)Species.Clone(), (IPlantingMaterial)PlantingMaterial.Clone(), SoilNeedRatio, (PlantRating)Rating.Clone(), (Finance)Price.Clone());
            return result;
        }


        #endregion API



        #region Construction




        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public Flower()
        {
            Species = null;
            PlantingMaterial = null;
            SoilNeedRatio = 0;
            Rating = null;
            Price = null;
        }



        /// <summary>
        /// Parametrized constructor.
        /// <br />
        /// Параметризованный конструктор.
        /// </summary>
        public Flower(Species species, IPlantingMaterial plantingMaterial, double soilNeedRatio, PlantRating rating, Finance price)
        {
            Species = species;
            PlantingMaterial = plantingMaterial;
            SoilNeedRatio = soilNeedRatio;
            Rating = rating;
            Price = price;
        }



        #endregion Construction

    }
}
