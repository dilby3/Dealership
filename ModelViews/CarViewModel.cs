using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Models;

namespace Dealership.ViewModels
{
    public class CarViewModel : VehicleViewModel
    {
        public Car Car
        {
            get
            {
                return base.Vehicle as Car;
            }
        }

        public int MaxPassengers
        {
            get
            {
                return Car.MaxPassengers;
            }
            set
            {
                if (Car.MaxPassengers == value)
                    return;

                Car.MaxPassengers = value;
                NotifyPropertyChanged();
            }
        }


        public CarViewModel(Car car) : base (car)
        {
        }
    }
}
