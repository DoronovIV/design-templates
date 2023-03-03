#pragma warning disable 1998

using Creational.Catalog.Builder;
using PlantioClassLibrary.Basics.Commodity;

namespace Creational.Performance
{
    public class BuilderPerformer : IPerformable
    {


        public async Task Run()
        {
            CommodityPackageDirector director = new CommodityPackageDirector(BasicCommodityType.Fertilizer, new Currency("RUB","P"));
            var builtObject = director.GetFertilizer();

            ShowPackageInfo(builtObject);
        }


        public void ShowPackageInfo(AbstractCommodity comm)
        {
            AnsiConsole.Write(new Markup("The builder has made a [green on black]fertilizer[/] package.\n\n"));
            AnsiConsole.Write(new Markup($"\tPrice = [green on black]{comm.Price}[/]\n"));
            AnsiConsole.Write(new Markup($"\tManufacturer = [green on black]{comm.Manufacturers?.FirstOrDefault()?.Title}[/]\n"));
            AnsiConsole.Write(new Markup($"\tMass = [green on black]{comm.Mass}kg[/]\n\n"));
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public BuilderPerformer()
        {

        }


    }
}
