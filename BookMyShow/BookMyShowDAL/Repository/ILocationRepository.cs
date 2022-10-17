using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public interface ILocationRepository
    {
        void addLocation(Location location);
        void updateLocation(Location location);
        void deleteLocation(int locationId);
        Location getLocationById(int locationId);
        IEnumerable<Location> GetLocations();
    }
}
