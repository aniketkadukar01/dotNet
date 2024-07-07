using EmployeeWebSolution.Entities;

namespace EmployeeWebSolution.Services
{
    public interface IEmployeeService
    {
        void Insert(Employee employee);
        List<Employee> GetAll();
        void Delete(int id);
        void Update(Employee employee);
    }
}
