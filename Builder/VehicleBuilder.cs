using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class VehicleBuilder
    {
        protected Vehicle _vehicle;
        public void CreateVehicle()
        {
            _vehicle = new Vehicle();
        }

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }

        public abstract void SetModel();
        public abstract void SetEngine();
        public abstract void SetTransmission();
        public abstract void SetBody();
        public abstract void SetDoors();
        public abstract void SetAccessories();
    }
}
