using ProjectUtilities;
using System;

namespace ShipmentTracking
{
    public class Package
    {
        public string WaybillNumber { get; private set; }

        public Package(string waybillNumber)
        {
            WaybillNumber = waybillNumber;
        }

        public Location TrackPackage()
        {
            // Perform some funky tracking logic
            //Return package location
            var location = new Location();
                                 
            try
            {

            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);

                throw;
            }

            return location;
        }
    }
}



