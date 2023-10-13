using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public int RowTotal { get; set; }
        public string RoofRackType { get; set; }
        public string Name { get; set; }
        public int HowManyDoors { get; set; }
        public int HorsePower { get; set; }
        public string EngineType { get; set; }
        public string BrandOwner { get; set; }
        public string Logo { get; set; }

      public void PrintSuvFacts()
        {
            Console.WriteLine($"These are my {GetType().Name} facts!");
            Console.WriteLine($" SUV Name: {Name} , BrandOwner: {BrandOwner}, Logo: {Logo} ,Seat Row Total: {RowTotal} , Total Of Doors: {HowManyDoors}, Type Of Roof Rack: {RoofRackType}, Engine Type: {EngineType}, Total Horsepower: {HorsePower}");
        }
    }
}
