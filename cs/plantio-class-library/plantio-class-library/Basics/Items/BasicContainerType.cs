namespace PlantioClassLibrary.Basics.Items
{
    public enum BasicContainerType
    {
        Unknown = 0,
        Planting = 1,   // used for holding plants;
        Embedding = 2   // used for holding another containers, including the 'planting' ones;
    } 
}
