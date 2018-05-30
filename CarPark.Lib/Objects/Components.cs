using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Lib.Objects
{
    public enum CarParts { Engine = 1, Transmission, Tire, Brake, Window, Door, Seat, Trunk, Rims, EngineOil, TransmissionOil, BreaksOil}
    public class Components
    {
        public CarParts CarParts { get; set; }
        public int CarPartsID { get; set; }
    }
}
