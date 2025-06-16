using System.Text.Json;
using StudentManagementSystem.Interfaces;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services;

public class StudentService : IStudentService
{
    private List<Student> students = [];
    private string filePath = "students.json";
    public StudentService() => LoadStudents();

    public void AddStudent(string FirstName, string SecondName, string Faculty)
    {
        throw new NotImplementedException();
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

    private void LoadStudents()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);

            students = JsonSerializer.Deserialize<List<Student>>(json) ?? [];
        }
        else
        {
            Console.WriteLine("File doesn't exist");
        }
    }
}
