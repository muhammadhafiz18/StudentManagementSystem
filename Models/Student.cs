namespace StudentManagementSystem.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Faculty { get; set; }
    public Dictionary<string, double> Grades { get; set; }
}
