using PlantioClassLibrary.Basics.Common;

namespace PlantioClassLibrary.Basics.Items
{
    public interface IContainer : ICloneable, ITradable
    {

        public string? GetName();


        public BasicContainerType GetBasicContainerType();

    }
}
