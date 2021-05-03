using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handson4.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Trainee { get; set; }
        public int Fees { get; set; }
        public string CourseDescription { get; set; }

        public static List<Course> courses = new List<Course>()
        {
            new Course() { CourseId=1,CourseName="Android",Trainee="Shawn",Fees=12000,CourseDescription="Android is a mobile operating system development"},
            new Course() { CourseId=2,CourseName="ASP.NET",Trainee="Kevin",Fees=10000,CourseDescription="ASP.NET is a open source web development framework"},
            new Course() { CourseId=3,CourseName="JSP",Trainee="Debaratha",Fees=10000,CourseDescription="Java server pages is a technology used for web page creations"},
            new Course() { CourseId=4,CourseName="Xamarin.forms",Trainee="Mark John",Fees=15000,CourseDescription="Xamarin forms is a cross platform UI tools"}

        };
    }
}