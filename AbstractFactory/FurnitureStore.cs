using AbstractFactory.Chair;
using AbstractFactory.Factory;
using AbstractFactory.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class FurnitureStore
    {
        private static FurnitureStore storeInstance = null;
        private IFurnitureFactory factory;

        private FurnitureStore() { }

        public static FurnitureStore GetFurnitureStoreInstance()
        {
            if (storeInstance == null)
            {
                storeInstance = new FurnitureStore();
            }

            return storeInstance;
        }

        public void ShowPriceList()
        {
            factory = new PlasticFactory();
            IChair pChair = factory.CreateChair();
            ITable pTable = factory.CreateTable();

            factory = new WoodFactory();
            IChair wChair = factory.CreateChair();
            ITable wTable = factory.CreateTable();

            Console.WriteLine("Gia ghe:");
            Console.WriteLine("* Ghe nhua: " + pChair.GetPrice() + " VND");
            Console.WriteLine("* Ghe go: " + wChair.GetPrice() + " VND");
            Console.WriteLine("Gia ban:");
            Console.WriteLine("* Ban nhua: " + pTable.GetPrice() + " VND");
            Console.WriteLine("* Ban go: " + wTable.GetPrice() + " VND");
        }
    }
}
