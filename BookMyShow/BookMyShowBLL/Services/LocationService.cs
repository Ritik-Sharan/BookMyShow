using BookMyShowDAL.Repository;
using BookMyShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyShowBLL.Services
{
    public class LocationService
    {
        ILocationRepository _locationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository= locationRepository;
        }

        //add location
        public void AddLocation(Location location)
        {
            _locationRepository.addLocation(location);
        }
        //update location
        public void UpdateLocation(Location location)
        {
            _locationRepository.updateLocation(location);
        }
        //delete location
        public void DeleteLocation(int locationId)
        {
            _locationRepository.deleteLocation(locationId);
        }
        //getlocationbyid location
        public Location GetLocationById(int locationId)
        {
            return _locationRepository.getLocationById(locationId);
        }
        //get locations
        public IEnumerable<Location> GetLocations()
        {
            return _locationRepository.GetLocations();
        }
    }
}
