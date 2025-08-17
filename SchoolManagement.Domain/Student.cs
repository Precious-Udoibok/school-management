
namespace SchoolManagement.Domain { 
    public class Student
    {
        public int ID { set; get; }
        public string Name { get; set; }
        public string Gender { set; get; }
        public Department Department_ID { set; get; }

    }
}
