namespace KodeCamp_5._0_Task_4
{
    internal class CourseRegistration
    {

        public CourseRegistration (int id, string name, string units,string status,
            string semester)
        {
            ID = id; Name = name; Units = units; Status = status;Semester = semester;
        }

        public void DisplayCourseRegistrationInfo()
        {
            Console.WriteLine($"This {Name} course has an id of {ID} with {Units} Units for {Semester} semester  and it is currently {Status}");
        }


        public int ID { get; set; }
        public string Name { get; set; }
        public string Units { get; set; }
        public string Status { get; set; }
        public Lecturer LecturerID { get; set; }
        public string Semester { set; get; }

        public Student StudentID { set; get; }

    }
}
