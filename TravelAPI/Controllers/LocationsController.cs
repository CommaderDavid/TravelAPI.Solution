using TravelAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private TravelAPIContext _db;

        public LocationsController(TravelAPIContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Location>> Get(string user_name, string country, string city, string review, int minRating)
        {
            var query = _db.Locations.AsQueryable();

            if (user_name != null)
            {
                query = query.Where(entry => entry.User_Name == user_name);
            }

            if (country != null)
            {
                query = query.Where(entry => entry.Country == country);
            }

            if (city != null)
            {
                query = query.Where(entry => entry.City == city);
            }

            if (review != null)
            {
                query = query.Where(entry => entry.Review == review);
            }

            if (minRating > 0)
            {
                query = query.Where(entry => entry.Rating >= minRating);
            }

            return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Location location)
        {
            _db.Locations.Add(location);
            _db.SaveChanges();
        }

        [HttpGet("{id}")]
        public ActionResult<Location> Get(int id)
        {
            return _db.Locations.FirstOrDefault(entry => entry.LocationId == id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Location location)
        {
            location.LocationId = id;
            _db.Entry(location).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Location locationToDelete = _db.Locations.FirstOrDefault(entry => entry.LocationId == id);
            _db.Locations.Remove(locationToDelete);
            _db.SaveChanges();
        }
    }
}