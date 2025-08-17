
namespace SchoolManagement.Domain { 
    public class Department
    {

        //Testing using Constructor 
        public Department(int id, string name)
        {
            ID = id; Name = name;
        }

        public Department () { }

        public int ID { get; set; }
        public string Name { get; set; }
        public College College_ID { get; set; }
    }
}
