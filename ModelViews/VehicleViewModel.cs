using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dealership.Models;

namespace Dealership.ViewModels
{
    public class VehicleViewModel : INotifyPropertyChanged
    {

        private Vehicle _vehicle;

        public Vehicle Vehicle
        {
            get { return _vehicle; }
        } 

        public string Make
        {
            get
            {
                return _vehicle.Make;
            }
            set
            {
                if (_vehicle.Make == value)
                    return;

                _vehicle.Make = value;
                NotifyPropertyChanged();
            }
        }

        public string Model
        {
            get
            {
                return _vehicle.Model;
            }
            set
            {
                if (_vehicle.Model == value)
                    return;

                _vehicle.Model = value;
                NotifyPropertyChanged();
            }
        }

        public int Year
        {
            get
            {
                return _vehicle.Year;
            }
            set
            {
                if (_vehicle.Year == value)
                    return;

                _vehicle.Year = value;
                NotifyPropertyChanged();
            }
        }

        public VehicleViewModel(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }


}
