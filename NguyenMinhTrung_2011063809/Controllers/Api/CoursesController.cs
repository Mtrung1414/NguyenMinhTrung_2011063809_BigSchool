﻿using Microsoft.AspNet.Identity;
using NguyenMinhTrung_2011063809.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenMinhTrung_2011063809.Controllers.Api
{
    public class CoursesController : ApiController
    {
        public ApplicationDbContext _dbContext { get; set; }

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();
            var course = _dbContext.Courses.Single(c => c.Id == id && c.LectureId == userId);
            if (course.IsCanceled)
                return NotFound();
            course.IsCanceled = true;
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
