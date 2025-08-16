
////Create Student Object 
using KodeCamp_5._0_Task_4;
using KodeCamp_5._0_Task_5;
using System.ComponentModel.Design;
//Console.WriteLine("----Testing Classes----");
//Console.WriteLine("----Test Student Class--");

//Student Student1 = new Student();
//Student1.ID = 1;
//Student1.Name = "Precious";
//Student1.Gender = "Female";
//Console.WriteLine($"Student with ID {Student1.ID}, Hello this is {Student1.Name}, i am a {Student1.Gender}");

//Console.WriteLine("\n-------------------------------------------------------");
//Console.WriteLine("\n----Test College Class using Constructor and Method--");
//College College1 = new College(1, "Computing Studies");
//College1.DisplayCollegeInfo();


//Console.WriteLine("\n-------------------------------------------------------");
//Console.WriteLine("\n----Test Department Class using Constructor--");
//Department Department1 = new Department(1, "Software Engineering");
//Console.WriteLine($"My deparment ID is {Department1.ID} The name is {Department1.Name}");


//Console.WriteLine("\n-------------------------------------------------------");
//Console.WriteLine("\n----Testing Hostel Class-----");
//Hostel Hostel1 = new Hostel();
//Hostel1.ID = 1; Hostel1.Name = "Block Hostel"; Hostel1.HostelClearance = "Granted";
//Console.WriteLine($"Hello i am new here, my hostel ID is {Hostel1.ID}, the name is {Hostel1.Name}, my clearance is {Hostel1.HostelClearance}");



//Console.WriteLine("\n-------------------------------------------------------");
//Console.WriteLine("\n----Test CourseRegistration Class using Constructor and Method--");
//CourseRegistration CourseRegistration1 = new CourseRegistration(2, "c#", "8", "active", "5.0");
//CourseRegistration1.DisplayCourseRegistrationInfo();


//Console.WriteLine("\n-------------------------------------------------------");
//Console.WriteLine("\n----Test Course Class--------");
//Course Course1 = new Course();
//Course1.ID = 1; Course1.CourseTitle = "Introduction to C#"; Course1.CourseCode = "C# 5.0";
//Console.WriteLine($"The {Course1.ID}st course i am taking is {Course1.CourseCode} -- {Course1.CourseTitle}");



//Console.WriteLine("\n----Test SchoolPortal Class--");
//SchoolPortal SchoolPortal1 = new SchoolPortal();
//SchoolPortal1.ID = 1;
//SchoolPortal1.PasswordHash = "$$^&*(^%%^";
//SchoolPortal1.MatricNumber = "BU21SEN1005";
//Console.WriteLine($"i want to login to my school portal {SchoolPortal1.ID}, My matric number is {SchoolPortal1.MatricNumber}, my passowrd is {SchoolPortal1.PasswordHash}");


//Console.WriteLine("\n--------Test Lecturer Class-----");
//Lecturer Lecturer1 = new Lecturer();
//Lecturer1.ID = 1;
//Lecturer1.Name = "Mr Gideon Edoghotu";
//Lecturer1.courses_taken = "C#, javaScript";
//Console.WriteLine($"My name is {Lecturer1.Name}, my lecturerID is {Lecturer1.ID}, i will be taking you {Lecturer1.courses_taken}");

//Console.WriteLine("\n--------Test FellowshipUnit CLass");
//FellowshipUnit FellowshipUnit1 = new FellowshipUnit(1, "Evening Bible Study");
//Console.WriteLine($"I joined {FellowshipUnit1.Name} fellowship Unit");


// Creating BankAccount Class
BankAccount BankAccount1 = new BankAccount("12389345", "Precious Solomon");
BankAccount1.CheckBalance();