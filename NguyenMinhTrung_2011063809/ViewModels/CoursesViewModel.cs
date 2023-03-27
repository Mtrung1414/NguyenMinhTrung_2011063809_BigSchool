using NguyenMinhTrung_2011063809.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenMinhTrung_2011063809.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}