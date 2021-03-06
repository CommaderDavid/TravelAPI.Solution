using System;
using TravelAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private TravelAPIContext _db;

        public ReviewsController(TravelAPIContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get(string user_name, string country, string city, string user_review, int minRating)
        {
            var query = _db.Reviews.AsQueryable();

            if (user_name != null)
            {
                query = query.Where(entry => entry.UserName == user_name);
            }

            if (country != null)
            {
                query = query.Where(entry => entry.Country == country);
            }

            if (city != null)
            {
                query = query.Where(entry => entry.City == city);
            }

            if (user_review != null)
            {
                query = query.Where(entry => entry.UserReview == user_review);
            }

            if (minRating > 0)
            {
                query = query.Where(entry => entry.Rating >= minRating);
            }

            return query.ToList();
        }

        [HttpPost]
        public void Post([FromBody] Review review)
        {
            _db.Reviews.Add(review);
            _db.SaveChanges();
        }

        [HttpGet("{id}")]
        public ActionResult<Review> Get(int id)
        {
            return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Review review)
        // need all of the review when updating it.
        {
            review.ReviewId = id;
            _db.Entry(review).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        // dont need all of the review to delete it, just the id
        {
            Review reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
            _db.Reviews.Remove(reviewToDelete);
            _db.SaveChanges();
        }
    }
}