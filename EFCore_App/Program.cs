namespace EFCore_App
{
    class Program
    {
        static void Main(string[] args)
        {
           var context = new SchoolContext();

            //Create operation
            Student student = new Student();
            student.Name = "Ravi";
            //context.Add(student);
            //context.SaveChanges();

            //Read Operation
            var id = 1;
            var studentData = context.Student.Where(s => id==1).ToList(); //First Method


            //studentData= context.Student.ToList();                        Second Method
            
            
            //var Data = context.Student.Find(id);                          Third Method
            //Console.WriteLine("data = {0}",Data.Name);
            foreach (var data in studentData){ 
                Console.WriteLine(data.Name);
            }
        }
    }
}