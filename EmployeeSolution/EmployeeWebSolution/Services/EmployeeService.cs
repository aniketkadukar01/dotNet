using EmployeeWebSolution.Entities;
using EmployeeWebSolution.Repositories;

namespace EmployeeWebSolution.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly EmployeeCollectionContext _context = new EmployeeCollectionContext();
        public void Delete(int id)
        {
            var context = _context.employees.Find(id);
            if (context != null)
            {
                _context.employees.Remove(context);
                _context.SaveChanges();
            }
        }

        public List<Employee> GetAll()
        {
            return _context.employees.ToList();
        }

        public void Insert(Employee employee)
        {
           _context.employees.Add(employee);
           _context.SaveChanges();

        }

        public void Update(Employee employee)
        {
            var context = _context.employees.Find(employee.Id);
            if (context != null)
            {
                context.Id = employee.Id;
                context.FirstName = employee.FirstName;
                context.LastName = employee.LastName;
                context.ContactNumber = employee.ContactNumber;
                context.Address = employee.Address;
                _context.employees.Update(context);
                _context.SaveChanges();
            }

        }
    }
}
