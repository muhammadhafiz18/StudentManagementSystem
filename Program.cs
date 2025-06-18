using StudentManagementSystem.Services;

var studentService = new StudentService();

while (true)
{
    Console.WriteLine("Studetn Management System");
    Console.WriteLine("1. Add student");
    Console.WriteLine("2. Assign a grade");
    Console.WriteLine("3. View a student");
    Console.WriteLine("4. View all students");
    Console.WriteLine("5. Cls");
    Console.WriteLine("6. Exit");

    string input = Console.ReadLine()!.Trim().ToLower();
    int id = 0;
    switch (input)
    {
        case "1":
        case "add student":
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine()!.Trim().ToLower();
            Console.WriteLine("Enter second name: ");
            string lastName = Console.ReadLine()!.Trim().ToLower();
            Console.WriteLine("Enter faculty: ");
            string faculty = Console.ReadLine()!.Trim().ToLower();

            studentService.AddStudent(firstName, lastName, faculty);
            break;

        case "2":
        case "assign a grade":
            Console.Clear();
            studentService.GetAllStudents();

            Console.Write("Enter student's id: ");
            id = int.Parse(Console.ReadLine()!.Trim());

            Console.Write("\nEnter subject name");
            string subject = Console.ReadLine()!.Trim().ToLower();

            Console.Write("\nEnter grade");
            double grade = double.Parse(Console.ReadLine()!.Trim());

            studentService.AssignGrade(id, subject, grade);
            break;

        case "3":
        case "view a student":
            Console.Clear();

            studentService.GetAllStudents();
            Console.Write("Enter student's id you want to see: ");

            id = int.Parse( Console.ReadLine()!.Trim());
            studentService.GetStudentById(id);
            break;

        case "4":
        case "view all students":
            Console.Clear();

            studentService.GetAllStudents();
            break;

        case "5":
        case "cls":
            Console.Clear();
            break;

        case "6":
        case "exit":
            Console.WriteLine("good bye");
            studentService.SaveStudents();
            return;

        default:
            Console.WriteLine("Invalid input. Please try again");
            break;
    }
}

