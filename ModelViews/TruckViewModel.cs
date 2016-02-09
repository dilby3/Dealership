using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Models;

namespace Dealership.ViewModels
{
    public class TruckViewModel : VehicleViewModel
    {
        public Truck Truck
        {
            get { return base.Vehicle as Truck; }
        }

        public bool FourWheelDrive
        {
            get
            {
                return Truck.FourWheelDrive;
            }
            set
            {
                if (Truck.FourWheelDrive == value)
                    return;

                Truck.FourWheelDrive = value;
                NotifyPropertyChanged();
            }
        }

        public TruckViewModel(Truck truck) : base(truck)
        {
        }


    }
}
