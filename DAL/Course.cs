namespace EntityFrameworkCore.Models
{
    public class Course
    {
        public object Teacher { get; internal set; }
        public object CourseName { get; internal set; }
    }
}