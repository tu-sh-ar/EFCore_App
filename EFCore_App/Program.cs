namespace EFCore_App
{
    class Program
    {
        static void Main(string[] args)
        {
           var context = new SchoolContext();

                                                           
            Student student = new Student();
            byte userChoice = 0;
            var id = 0;
            string name;
            const byte create = 1;
            const byte update = 2;
            const byte delete = 3;
            const byte view = 4;
            Console.WriteLine("************* Console App For Entity Framework Implementation ***************");
            do
            {
                Console.WriteLine("\nList Of Operation To Do:- \n 1.Create \n 2.Update \n 3.Delete\n 4.View \n 5.Quit");
                Console.WriteLine("\nPress Any Realative Number To Proceed");
                try
                {
                    userChoice = byte.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("\n\t!Please Select From Option Above");
                }

                switch (userChoice)
                {
                    case 0:
                        break;
                    case create:

                        Console.WriteLine("----Enter Student Name----");
                        name = Console.ReadLine();
                        student.Name = name;
                        student.StudentId = id;
                        Create(student);
                        break;

                    case update:
                        Console.WriteLine("----Enter Student Id----");
                        id = int.Parse( Console.ReadLine());
                        Console.WriteLine("----Enter Name To Update----");
                        name = Console.ReadLine();
                        student.Name = name;
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
            while (userChoice != 5 );
        }

        static bool Update(Student student)
        {

            using(var context = new SchoolContext())
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

        static void Create(Student student)
        {
            using (var context = new SchoolContext())
            {
                context.Add(student);
                context.SaveChanges();
                Console.WriteLine("+++ Created +++") ;
            }
        }
        static void Delete(Student student)
        {
            using (var context = new SchoolContext())
            {
                context.Remove(student);
                
                context.SaveChanges();
                
                Console.WriteLine("--- Deleted ---") ;
            }
        }
       
        static void Read()
        {
            using (var context = new SchoolContext())
            {
                
                var studentData = context.Student.Where(s =>  true ).ToList();
                //studentData= context.Student.ToList();                        Second Method


                //var Data = context.Student.Find(id);                          Third Method
                //Console.WriteLine("data = {0}",Data.Name);
                foreach (var data in studentData)
                {
                    Console.WriteLine(data.StudentId+"  "+data.Name);
                }
            }

        }
    }
}