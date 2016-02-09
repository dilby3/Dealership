using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Truck : Vehicle
    {
        private bool _fourWheelDrive;

        public bool FourWheelDrive
        {
            get
            {
                return _fourWheelDrive;
            }
            set
            {
                if (_fourWheelDrive == value)
                    return;

                _fourWheelDrive = value;
            }
        }


    }
}
