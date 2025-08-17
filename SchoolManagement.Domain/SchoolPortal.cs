

namespace SchoolManagement.Domain
{
    public class SchoolPortal
    {
        public int ID {set; get;}
        public string PasswordHash { set; get; }
        public string MatricNumber {  set; get; }
        public Student StudentID { set; get; }
        
    }
}
