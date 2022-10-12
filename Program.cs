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
            studentList.Add(new Student("Bob", "Black"));
            studentList.Add(new Student("Ben", "Looper"));

            int choice = 0;
            while (choice != 8)
            {
                Console.Clear();
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Display Students");
                Console.WriteLine("2 - Student Details");
                Console.WriteLine("3 - Add a Student");
                Console.WriteLine("4 - Remove a Student");
                Console.WriteLine("5 - Search for a Student");
                Console.WriteLine("6 - Edit a Student");
                Console.WriteLine("7 - Sort Students");
                Console.WriteLine("8 - Quit");
                Console.WriteLine();
                int.TryParse(Console.ReadLine(), out choice);

                if (choice == 1)
                {
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("You chose option 3");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("You chose option 4");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 5)
                {
                    Console.WriteLine("You chose option 5");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("You chose option 6");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 7)
                {
                    Console.WriteLine("You chose option 7");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 8)
                {
                    Console.WriteLine("Cya!");
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}