namespace Classes_Programming_Assignment___Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student person = new Student("Robert", "Ross");
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.StudentNumber);
        }
    }
}