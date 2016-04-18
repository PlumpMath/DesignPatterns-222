using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FordFigoBuilder : VehicleBuilder
    {
        public override void SetAccessories()
        {
            _vehicle.Accessories.Add("Glass");
            _vehicle.Accessories.Add("Floor Mats");
        }

        public override void SetBody()
        {
            _vehicle.Body = "HATCH BACK";
        }

        public override void SetDoors()
        {
            _vehicle.Doors = 4;
        }

        public override void SetEngine()
        {
            _vehicle.Engine = "1.4 V Turbo";
        }

        public override void SetModel()
        {
            _vehicle.Model = "Ford Figo";
        }

        public override void SetTransmission()
        {
            _vehicle.Transmission = "5 Gear Manual";
        }
    }
}
