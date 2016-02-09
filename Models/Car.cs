using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Car : Vehicle
    {
        private int _maxPassengers;

        public int MaxPassengers
        {
            get
            {
                return _maxPassengers;
            }
            set
            {
                if (_maxPassengers == value)
                    return;

                _maxPassengers = value;
            }
        }
    }
}
