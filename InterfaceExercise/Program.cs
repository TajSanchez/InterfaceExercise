using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany **DONE

            //Create 3 classes called Car , Truck , & SUV **DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common. **DONE
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.                    |
             *                                            **DONE
             *                                                |
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size **DONE
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             *  **DONE
             */

            //Now, create objects of your 3 classes and give their members values; **DONE
            //Creatively display and organize their values
            var companies = new List<ICompany>();
            var vehicles = new List<IVehicle>();

            var bmw = new Car();
            bmw.Name = "328i";
            bmw.BrandOwner = "BMW Motor Company";
            bmw.TrunkType = "Standard automatic";
            bmw.LuxuryFeature = "Heated and Cooling Seating";
            bmw.HowManyDoors = 4;
            bmw.EngineType = "Inline Switch Engine";
            bmw.Logo = "BMW";
            bmw.HorsePower = 240;
            companies.Add(bmw);
            vehicles.Add(bmw);

            var audi = new Suv();
            audi.Name = "Q3";
            audi.BrandOwner = "Volkswagen Group";
            audi.RoofRackType = "Flused Side Rails";
            audi.RowTotal = 2;
            audi.HowManyDoors = 4;
            audi.EngineType = "Turbocharged 2.0 Liter Engine";
            audi.Logo = "Audi";
            audi.HorsePower = 228;
            companies.Add(audi);
            vehicles.Add(audi);

            var toyota = new Truck();
            toyota.Name = "Tacoma";
            toyota.BrandOwner = "Toyota Motor Corp.";
            toyota.CargoBedType = "6Ft Long";
            toyota.WheeldriveType = "4 Wheel Drive";
            toyota.HowManyDoors = 4;
            toyota.EngineType = "Turbocharged 2.4 Liter 4 Cylinder Engine";
            toyota.Logo = "Toyota";
            toyota.HorsePower = 278;
            companies.Add(toyota);
            vehicles.Add(toyota);


            bmw.PrintCarFacts();
            Console.WriteLine();

            audi.PrintSuvFacts();
            Console.WriteLine();

            toyota.PrintTruckFacts();
            Console.WriteLine();

            Console.WriteLine("Here is the info for only IVehicles.");
            foreach(var vehicle  in vehicles)
            {
                Console.WriteLine($"These are my {vehicle.GetType().Name} facts!");
                Console.WriteLine($"Car Name: {vehicle.Name} , Total Of Doors: {vehicle.HowManyDoors}, Engine Type: {vehicle.EngineType}, Total Horsepower: {vehicle.HorsePower}");
                Console.WriteLine();
            }

            Console.WriteLine("Here is the info for only ICompany.");
            foreach (var company in companies)
            {
                Console.WriteLine($"These are my {company.GetType().Name} facts!");
                Console.WriteLine($"Brand Owner: {company.BrandOwner} , Logo: {company.Logo}");
                Console.WriteLine();
            }

        }

    }
}
