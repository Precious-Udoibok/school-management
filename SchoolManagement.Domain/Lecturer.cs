
namespace SchoolManagement.Domain
{
    public class Lecturer
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string courses_taken { set; get; }
        public Department Department_Id { set; get;  }
    }
}
