using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car:IVehicle,ICompany
    {
        public string TrunkType { get; set; }

        public string LuxuryFeature { get; set; }
        public string Name { get; set; }
        public int HowManyDoors { get; set; }
        public int HorsePower { get; set; }
        public string EngineType { get; set; }
        public string BrandOwner { get; set; }
        public string Logo { get; set; }

        public void PrintCarFacts()
        {
            Console.WriteLine($"These are my {GetType().Name} facts!");
            Console.WriteLine($" Car Name: {Name} , BrandOwner: {BrandOwner}, Luxary Feature: {LuxuryFeature}, Logo: {Logo} , Total Of Doors: {HowManyDoors}, Trunk Type: {TrunkType}, Engine Type: {EngineType}, Total Horsepower: {HorsePower}");
        }
    }
}
