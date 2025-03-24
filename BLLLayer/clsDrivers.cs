using AccessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnisLayer
{
    public class clsDrivers
    {

        #region Static Methods

        public static DataTable GetAllDrivers() => AD_Drivers.GetAllDrivers();

        public static int GetPersonIDByDriverID(int DriverID) => AD_Drivers.GetPersonID(DriverID);


        #endregion

    }
}
