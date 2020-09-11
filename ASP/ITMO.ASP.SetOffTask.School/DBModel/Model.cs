using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set;}
    public string SecondName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }

}

public class Performance
{
    public int PerformanceId { get; set; }
    public Student Student { get; set; }
    public Course Course { get; set; }
    public int Mark { get; set; }
}
