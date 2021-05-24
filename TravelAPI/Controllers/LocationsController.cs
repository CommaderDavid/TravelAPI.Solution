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
        public ActionResult<IEnumerable<Location>> Get(string name, string country, string city, string review, int minRating)
        {
            var query = _db.Locations.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
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
    }
}