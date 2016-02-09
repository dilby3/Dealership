using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Vehicle
    {
        #region Fields

        private string _make;
        private string _model;
        private int _year;

        #endregion

        #region Properties

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                if (_make == value)
                    return;

                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (_model == value)
                    return;

                _model = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (_year == value)
                    return;

                _year = value;
            }
        }

        #endregion
    }
}
