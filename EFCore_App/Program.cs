namespace EFCore_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();


            Student student = new Student();
            Course course = new Course();

            byte userChoice = 0;
            const byte  studentRecord=1;
            const byte courseRecord=2;
            const byte  @continue=3;

            Console.WriteLine("************* Console App For Entity Framework Implementation ***************");
            do
            {
                Console.WriteLine("\n*******************\t\tMain Menu\t\t***************\n");
                Console.WriteLine("1. Go To Student Records\n2. Go To Course Records\n3. Quit \n ___Press 1 or 2 To Continue and 3 to Quit___");
                userChoice = ReadUserInput();

                if (userChoice == studentRecord)
                {

                    StudentDb.StudentDBOperations(student);
                }
                else if(userChoice == courseRecord)
                {
                    CourseDb.CourseDBOperations(course);
                }
            }
            while (userChoice != @continue);

        }

        internal static byte ReadUserInput()
        {
            byte userChoice = 0;
            try
            {
                userChoice = byte.Parse(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("\n\t!Please Select From Option Above");
                return byte.MinValue;
            }
            return userChoice;
        }






    }

    internal static class StudentDb
    {
        //Swithes here when 1 pressed
        internal static void StudentDBOperations(Student student)
        {
            var id = 0;
            string name;
            const byte create = 1;
            const byte update = 2;
            const byte delete = 3;
            const byte view = 4;

            Console.WriteLine("\nList Of Operation To Do:- \n 1.Create \n 2.Update \n 3.Delete\n 4.View \n 5.Quit");
            Console.WriteLine("\nPress Any Realative Number To Proceed");
            var userChoice = Program.ReadUserInput();
            switch (userChoice)
            {
                case 0:
                    break;
                case create:

                    Console.WriteLine("----Enter Student Name----");
                    name = Console.ReadLine();
                    student.StudentName = name;
                    student.StudentId = id;
                    Create(student);
                    break;

                case update:
                    Console.WriteLine("----Enter Student Id----");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("----Enter Name To Update----");
                    name = Console.ReadLine();
                    student.StudentName = name;
                    student.StudentId = id;
                    bool flagUpdate = Update(student);
                    if (flagUpdate)
                    {
                        Console.WriteLine("Updated");
                    }
                    else
                    {
                        Console.WriteLine("Sorry the record is not updated!");

                    }
                    break;

                case delete:
                    Console.WriteLine("----Enter Student Id To Delete----");
                    id = int.Parse(Console.ReadLine());
                    student.StudentId = id;
                    Delete(student);
                    break;

                case view:
                    Read();
                    break;


            }
        }
            //Reads User Input ANd Return Bytes
           

            //Updates Student record
            internal static bool Update(Student student)
            {

                using (var context = new SchoolContext())
                {
                    try
                    {
                        context.Student.Update(student);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                return true;

            }

            //Creates new Student Record
            internal static void Create(Student student)
            {
                using (var context = new SchoolContext())
                {
                    context.Add(student);
                    context.SaveChanges();
                    Console.WriteLine("+++ Created +++");
                }
            }

            //Deletes Student Record
           internal  static void Delete(Student student)
            {
                using (var context = new SchoolContext())
                {
                    context.Remove(student);

                    context.SaveChanges();

                    Console.WriteLine("--- Deleted ---");
                }
            }

            //Reads Student Records
            internal static void Read()
            {
                using (var context = new SchoolContext())
                {

                    var studentData = context.Student.Where(s => true).ToList();
                    //studentData= context.Student.ToList();                        Second Method


                    //var Data = context.Student.Find(id);                          Third Method
                    //Console.WriteLine("data = {0}",Data.Name);
                    foreach (var data in studentData)
                    {
                        Console.WriteLine(data.StudentId + "  " + data.StudentName);
                    }
                }

            }
        
    }

    //COurse Class
    internal static class CourseDb
    {
        //Swithes here when 1 pressed
        internal static void CourseDBOperations(Course course)
        {
            var id = 0;
            string name;
            const byte create = 1;
            const byte update = 2;
            const byte delete = 3;
            const byte view = 4;

            Console.WriteLine("\nList Of Operation To Do:- \n 1.Create \n 2.Update \n 3.Delete\n 4.View \n 5.Quit");
            Console.WriteLine("\nPress Any Realative Number To Proceed");
            var userChoice = Program.ReadUserInput();
            switch (userChoice)
            {
                case 0:
                    break;
                case create:

                    Console.WriteLine("----Enter Course Name----");
                    name = Console.ReadLine();
                    course.CourseName = name;
                    course.CourseId = id;
                    Create(course);
                    break;

                case update:
                    Console.WriteLine("----Enter Course Id----");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("----Enter Name To Update----");
                    name = Console.ReadLine();
                    course.CourseName = name;
                    course.CourseId = id;
                    bool flagUpdate = Update(course);
                    if (flagUpdate)
                    {
                        Console.WriteLine("Updated");
                    }
                    else
                    {
                        Console.WriteLine("Sorry the record is not updated!");

                    }
                    break;

                case delete:
                    Console.WriteLine("----Enter Course Id To Delete----");
                    id = int.Parse(Console.ReadLine());
                    course.CourseId = id;
                    Delete(course);
                    break;

                case view:
                    Read();
                    break;


            }
        }
        
       

        //Updates Course record
        internal static bool Update(Course course)
        {

            using (var context = new SchoolContext())
            {
                try
                {
                    context.Course.Update(course);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return true;

        }

        //Creates new Course Record
        internal static void Create(Course course)
        {
            using (var context = new SchoolContext())
            {
                context.Add(course);
                context.SaveChanges();
                Console.WriteLine("+++ Created +++");
            }
        }

        //Deletes Course Record
        internal static void Delete(Course course)
        {
            using (var context = new SchoolContext())
            {
                context.Remove(course);

                context.SaveChanges();

                Console.WriteLine("--- Deleted ---");
            }
        }

        //Reads Course Records
        internal static void Read()
        {
            using (var context = new SchoolContext())
            {

                var courseData = context.Course.Where(s => true).ToList();
                //studentData= context.Student.ToList();                        Second Method


                //var Data = context.Student.Find(id);                          Third Method
                //Console.WriteLine("data = {0}",Data.Name);
                foreach (var data in courseData)
                {
                    Console.WriteLine(data.CourseId + "  " + data.CourseName);
                }
            }

        }

    }
}
