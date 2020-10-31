using System;
using System.Collections.Generic;
using System.Text;

namespace labTask3
{
    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;
        public void course(String CourseName, String CourseCode, int CourseCredit)
        {
            courseName = CourseName;
            courseCode = CourseCode;
            courseCredit = CourseCredit;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course Code  : " + courseCode);
            Console.WriteLine("Course Credit : " + courseCredit);

        }
    }
}