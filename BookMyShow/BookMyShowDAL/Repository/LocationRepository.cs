using BookMyShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookMyShowDAL.Repository
{
    public class LocationRepository : ILocationRepository
    {
        BookMyShowDB_Context _bookMyShowDB_Context;

        public LocationRepository(BookMyShowDB_Context bookMyShowDB_Context)
        {
            _bookMyShowDB_Context = bookMyShowDB_Context;
        }
        public void addLocation(Location location)
        {
            _bookMyShowDB_Context.location.Add(location);
            _bookMyShowDB_Context.SaveChanges();
        }

        public void deleteLocation(int locationId)
        {
            var location = _bookMyShowDB_Context.location.Find(locationId);
            _bookMyShowDB_Context.location.Remove(location);
            _bookMyShowDB_Context.SaveChanges();
        }

        public Location getLocationById(int locationId)
        {
            return _bookMyShowDB_Context.location.Find(locationId);
        }

        public IEnumerable<Location> GetLocations()
        {
            return _bookMyShowDB_Context.location.ToList(); 
        }

        public void updateLocation(Location location)
        {
            _bookMyShowDB_Context.Entry(location).State = EntityState.Modified;
            _bookMyShowDB_Context.SaveChanges();
        }
    }
}
