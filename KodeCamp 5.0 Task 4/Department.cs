
namespace KodeCamp_5._0_Task_4
{
    internal class Department
    {

        //Testing using Constructor 
        public Department(int id, string name)
        {
            ID = id; Name = name;
        }


        public int ID { get; set; }
        public string Name { get; set; }
        public College College_ID { get; set; }
    }
}
