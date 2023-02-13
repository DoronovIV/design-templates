using PlantioClassLibrary.Basics.Common;

namespace PlantioClassLibrary.Basics.Items
{
    public interface IContainer
    {

        public string? GetName();


        public BasicContainerType GetBasicContainerType();


        public Finance? GetPrice();

    }
}
