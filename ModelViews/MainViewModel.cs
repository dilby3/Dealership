using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Dealership.Models;

namespace Dealership.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Fields

        private ObservableCollection<VehicleViewModel> _vehicleViewModels;

        private VehicleViewModel _selectedVehicleViewModel;

        #endregion

        #region Properties

        public ObservableCollection<VehicleViewModel> VehicleViewModels
        {
            get
            {
                return _vehicleViewModels;
            }
            set
            {
                if (_vehicleViewModels == value)
                    return;

                _vehicleViewModels = value;
                NotifyPropertyChanged();
            }
        }

        public VehicleViewModel SelectedVehicleViewModel
        {
            get
            {
                return _selectedVehicleViewModel;
            }
            set
            {
                if (_selectedVehicleViewModel == value)
                    return;

                _selectedVehicleViewModel = value;
                NotifyPropertyChanged();
            }
        }

        #endregion

        #region Constructors

        public MainViewModel()
        {
            _vehicleViewModels = new ObservableCollection<VehicleViewModel>();
            _vehicleViewModels.Add(new TruckViewModel(new Truck() { Make = "Ford", Model = "4x4", Year = 2008, FourWheelDrive = true }));
            _vehicleViewModels.Add(new TruckViewModel(new Truck() { Make = "Chevy", Model = "4x4", Year = 2008, FourWheelDrive = false }));
            _vehicleViewModels.Add(new CarViewModel (new Car() { Make = "Toyota", Model = "Camry", Year = 2005, MaxPassengers = 2 })); 
            _vehicleViewModels.Add(new CarViewModel( new Car() { Make = "Toyota", Model = "Camry", Year = 2009,  MaxPassengers= 5})); 
        }

        #endregion


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
