
namespace SchoolManagement.Domain
{

    public class Course
    {
        public int ID { set; get; }
        public string CourseCode { set; get; }
        public string CourseTitle { set; get; }
        public Lecturer Lecturer_ID { set; get; }
    }
}