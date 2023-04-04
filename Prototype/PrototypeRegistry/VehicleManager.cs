using Prototype.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.PrototypeRegistry
{
    //public class VehicleManager
    //{
    //    private Dictionary<string, Vehicle> vehicleMap;
    //    public Dictionary<string, Vehicle> VehicleMap 
    //    { 
    //        get => vehicleMap; 
    //        set => vehicleMap = value; 
    //    }

    //    public VehicleManager()
    //    {
    //        VehicleMap = new Dictionary<string, Vehicle>();
    //        VehicleMap.Add("GPLX1", new Bus("Vinbus", "GPLX1", "Green", 40));
    //        VehicleMap.Add("X3", new Car("BMW", "X3", "Blue", 235));
    //    }

    //    public List<Vehicle> GetByName(string name)
    //    {
    //        List<Vehicle> vehicles = new List<Vehicle>();
    //        foreach (var vehicle in VehicleMap)
    //        {
    //            if (vehicle.Value.Name == name)
    //            {
    //                vehicles.Add(vehicle.Value.Clone());
    //            }
    //        }

    //        return vehicles;
    //    }

    //    public List<Vehicle> GetByColor(string color)
    //    {
    //        List<Vehicle> vehicles = new List<Vehicle>();
    //        foreach (var vehicle in VehicleMap)
    //        {
    //            if (vehicle.Value.Color == color)
    //            {
    //                vehicles.Add(vehicle.Value.Clone());
    //            }
    //        }

    //        return vehicles;
    //    }

    //}
}
