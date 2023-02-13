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

namespace Creational.Controls
{
    public class Application
    {

        public async Task Run()
        {
            await RunSingleton();
        }


        public async Task RunSingleton()
        {
            await Task.Run(() =>
            {

                AlternativeStock ordinaryStock = new();
                AlternativeStock ordinaryStock1 = new();
                AlternativeStock ordinaryStock2 = new();

                //AlternativeStockSingleton exceptionalStock = new();
                AlternativeStockSingleton? exceptionalStock1 = AlternativeStockSingleton.GetInstance();
                AlternativeStockSingleton? exceptionalStock2 = AlternativeStockSingleton.GetInstance();

                AnsiConsole.Write(new Markup(AlternativeStock.GetSomeInformation()));
                AnsiConsole.Write(new Markup(AlternativeStockSingleton.GetSomeInformation()));

            });
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
