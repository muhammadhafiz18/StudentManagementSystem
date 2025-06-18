using System.Text.Json;
using StudentManagementSystem.Interfaces;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services;

public class StudentService : IStudentService
{
    private List<Student> students = [];
    private string filePath = "students.json";
    public StudentService() => LoadStudents();

    public void AddStudent(string firstName, string secondName, string faculty)
    {
        var student = new Student()
        {
            Id = students.Count == 0 ? 1 : students.Last().Id + 1,
            FirstName = firstName,
            SecondName = secondName,
            Faculty = faculty
        };

        students.Add(student);
    }

    public void AssignGrade(int id, string subject, double grade)
    {
        throw new NotImplementedException();
    }

    public void GetAllStudents()
    {
        throw new NotImplementedException();
    }

    public void GetStudentById(int id)
    {
        throw new NotImplementedException();
    }

    public void SaveStudents()
    {
        var options = new JsonSerializerOptions()
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(students, options);

        File.WriteAllText(filePath, json);
    }

    private void LoadStudents()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);

            if (json != null)
            {
                students = JsonSerializer.Deserialize<List<Student>>(json) ?? [];
            }

        }
        else
        {
            Console.WriteLine("File doesn't exist");
        }
    }
}
