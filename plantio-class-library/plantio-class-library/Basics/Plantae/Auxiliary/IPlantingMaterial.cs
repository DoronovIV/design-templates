using PlantioClassLibrary.Basics.Common;

namespace PlantioClassLibrary.Basics.Plantae.Auxiliary
{
    public interface IPlantingMaterial : ITradable, ICloneable
    {


        /// <summary>
        /// Get name of the planting material.
        /// <br />
        /// Получить название посадочного материала.
        /// </summary>
        public string? GetName();


        /// <summary>
        /// Get reference to the material manufacturer.
        /// <br />
        /// Получить ссылку на производителя материала.
        /// </summary>
        public Manufacturer? GetManufacturer();


    }
}
