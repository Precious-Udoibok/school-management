
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Domain
{
    public class College
    {
        public College (int id, string name)
        {
            ID = id; Name = name;
        }


        public void DisplayCollegeInfo()
        {
            Console.WriteLine($"My college ID is {ID} The name is {Name}");
        }
        public int ID { set; get; }
        public string Name{ set; get; }
    }
}
