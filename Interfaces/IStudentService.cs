namespace StudentManagementSystem.Interfaces;

public interface IStudentService
{
    void AddStudent(string FirstName, string SecondName, string Faculty);
    void AssignGrade(int id, string subject, double grade);
    void GetStudentById(int id);
    void GetAllStudents();
}