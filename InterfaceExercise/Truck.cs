using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck:IVehicle,ICompany
    {
        public string CargoBedType { get; set; }

        public string WheeldriveType { get; set; }
        public string Name { get; set; }
        public int HowManyDoors { get; set; }
        public int HorsePower { get; set; }
        public string EngineType { get; set; }
        public string BrandOwner { get; set; }
        public string Logo { get; set; }

        public void PrintTruckFacts()
        {
            Console.WriteLine($"These are my {GetType().Name} facts!");
            Console.WriteLine($" Truck Name: {Name} , BrandOwner: {BrandOwner}, Logo: {Logo}, Wheel Drive Type : {WheeldriveType}, Total Of Doors: {HowManyDoors}, Cargobed Type: {CargoBedType}, Engine Type: {EngineType}, Total Horsepower: {HorsePower}");
        }
    }
}
