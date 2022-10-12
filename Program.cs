namespace Classes_Programming_Assignment___Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Hunter", "Wilson"));
            studentList.Add(new Student("Kian", "Dufraimont"));
            studentList.Add(new Student("Joe", "Looper"));

            string firstnameforthing = Console.ReadLine();
            string lastnameforthing = Console.ReadLine();
            studentList.Add(new Student(firstnameforthing, lastnameforthing));

            foreach (var student in studentList)
            {
                Console.WriteLine(student);
                Console.WriteLine(student.StudentNumber);
                Console.WriteLine(student.Email);
            }
        }
    }
}