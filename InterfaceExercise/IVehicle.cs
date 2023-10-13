using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Name { get; set; }
        public int HowManyDoors { get; set; }

        public int HorsePower { get; set; }

        public string EngineType { get; set; }
    }
}
