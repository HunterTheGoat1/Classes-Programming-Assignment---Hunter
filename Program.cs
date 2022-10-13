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
            studentList.Add(new Student("Drayden", "Hooper"));
            studentList.Add(new Student("Ben", "Looper"));

            int choice = 0;
            while (choice != 8)
            {
                Console.Clear();
                Console.WriteLine("Welcome to my student menu.  Please select an option:");
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
                    Console.Clear();
                    int count = 0;
                    foreach (var student in studentList)
                    {
                        count++;
                        Console.WriteLine($"{count} - {student}\n");
                    }
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("List of students:\n");
                    int count = 0;
                    foreach (var student in studentList)
                    {
                        count++;
                        Console.WriteLine($"{count} - {student}\n");
                    }
                    Console.WriteLine("What student do you want to see? (type the number in front of their name)");
                    int indexPick;
                    while (!Int32.TryParse(Console.ReadLine(), out indexPick)) Console.WriteLine("Invalid choice");
                    indexPick -= 1;
                    if (indexPick < count && indexPick >= 0) Console.WriteLine($"First name: {studentList[indexPick].FirstName}\nLast name: {studentList[indexPick].LastName}\nStudent number: {studentList[indexPick].StudentNumber}\nEmail: {studentList[indexPick].Email}");
                    else Console.WriteLine("Invalid choice");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("What is their first name?");
                    string firstNamePick = Console.ReadLine().Trim();
                    firstNamePick = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(firstNamePick.ToLower());
                    Console.WriteLine("What is their last name?");
                    string lastNamePick = Console.ReadLine().Trim();
                    lastNamePick = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(lastNamePick.ToLower());
                    studentList.Add(new Student(firstNamePick, lastNamePick));
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    Console.WriteLine("List of students:\n");
                    int count = 0;
                    foreach (var student in studentList)
                    {
                        count++;
                        Console.WriteLine($"{count} - {student} ({student.StudentNumber})\n");
                    }
                    Console.WriteLine("What student do you want to remove? (type the number in front of their name)");
                    int indexPick;
                    while (!Int32.TryParse(Console.ReadLine(), out indexPick)) Console.WriteLine("Invalid choice");
                    indexPick -= 1;
                    if (indexPick < count && indexPick >= 0) studentList.RemoveAt(indexPick);
                    else Console.WriteLine("Invalid choice");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 5)
                {
                    string lastNameToLookFor;
                    Console.WriteLine("Type the last name of the student you are looking for");
                    lastNameToLookFor = Console.ReadLine().ToLower();
                    foreach (var student in studentList)
                    {
                        if (student.LastName.ToLower().Contains($"{lastNameToLookFor}"))
                        Console.WriteLine($"First name: {student.FirstName}\nLast name: {student.LastName}\nStudent number: {student.StudentNumber}\nEmail: {student.Email}\n\n");
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 6)
                {
                    Console.Clear();
                    Console.WriteLine("List of students:\n");
                    int count = 0;
                    foreach (var student in studentList)
                    {
                        count++;
                        Console.WriteLine($"{count} - {student} ({student.StudentNumber})\n");
                    }
                    Console.WriteLine("What student do you want to edit? (type the number in front of their name)");
                    int indexPick;
                    while (!Int32.TryParse(Console.ReadLine(), out indexPick)) Console.WriteLine("Invalid choice");
                    indexPick -= 1;
                    if (indexPick < count && indexPick >= 0)
                    {
                        Console.WriteLine("Do you want to edit their first or last name?");
                        string nameToEdit = Console.ReadLine();
                        if(nameToEdit.ToLower().Contains("first"))
                        {
                            Console.WriteLine("What do you want their first name to be?");
                            string name = Console.ReadLine().Trim();
                            name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
                            studentList[indexPick].FirstName = name;
                        }
                        else if (nameToEdit.ToLower().Contains("last"))
                        {
                            Console.WriteLine("What do you want their last name to be?");
                            string name = Console.ReadLine().Trim();
                            name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
                            studentList[indexPick].LastName = name;
                        }
                    }
                    else Console.WriteLine("Invalid choice");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == 7)
                {
                    studentList.Sort();
                    Console.WriteLine("The list was sorted");
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