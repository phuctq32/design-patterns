﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FurnitureStore store = FurnitureStore.GetFurnitureStoreInstance();
            store.ShowPriceList();
            Console.ReadKey();
        }
    }
}
