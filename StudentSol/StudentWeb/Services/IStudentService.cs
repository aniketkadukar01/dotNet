using StudentWeb.Models;

namespace StudentWeb.Services
{
    public interface IStudentService
    {
        void Insert(Student student);
        void Delete(int id);
        void Update(Student student);
        List<Student> GetAll();
        List<Student> Sort();

        List<Student> SearchByStatus(string status);
    }
}
