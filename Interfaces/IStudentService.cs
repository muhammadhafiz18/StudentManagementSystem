namespace StudentManagementSystem.Interfaces;

public interface IStudentService
{
    void AddStudent(string firstName, string secondName, string faculty);
    void AssignGrade(int id, string subject, double grade);
    void GetStudentById(int id);
    void GetAllStudents();
}