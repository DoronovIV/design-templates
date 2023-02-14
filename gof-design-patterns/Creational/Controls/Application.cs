global using System;
global using System.Collections.Generic;
global using System.Linq;
global using System.Text;
global using System.Threading.Tasks;

global using PlantioClassLibrary;
global using PlantioClassLibrary.Basics;
global using PlantioClassLibrary.Basics.Commodity;
global using PlantioClassLibrary.Basics.Common;
global using PlantioClassLibrary.Basics.Items;
global using PlantioClassLibrary.Basics.Plantae.Auxiliary;
global using PlantioClassLibrary.Basics.Plantae.Main;
global using PlantioClassLibrary.Basics.RealEstate;
global using PlantioClassLibrary.Basics.Region;
global using PlantioClassLibrary.Basics.Volatile;
global using Creational.Catalog.Singleton;

global using Spectre.Console;
global using Creational.Catalog.Prototype;
global using Creational.Performance;


#pragma warning disable 1998


namespace Creational.Controls
{
    public partial class Application
    {

        public async Task Run()
        {
            IPerformable pattern = new PrototypePerformer();
            await pattern.Run();
        }



        /// <summary>
        /// Default constructor.
        /// <br />
        /// Конструктор по умолчанию.
        /// </summary>
        public Application()
        {

        }


    }
}
