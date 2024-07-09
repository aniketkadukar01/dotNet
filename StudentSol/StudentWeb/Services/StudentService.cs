using StudentWeb.Models;
using StudentWeb.Repositories;

namespace StudentWeb.Services
{
    public class StudentService : IStudentService
    {
        public void Delete(int id)
        {
            using (var context = new StudentCollectionContext())
            {
                var FindStudent = context.students.Find(id);
                if (FindStudent != null)
                {
                    context.students.Remove(FindStudent);
                    context.SaveChanges();
                }
            }

        }

        public List<Student> GetAll()
        {
            using (var context = new StudentCollectionContext())
            {
                var students = context.students.ToList();
                return students;
            }
        }

        public void Insert(Student student)
        {
            using (var context = new StudentCollectionContext())
            {
                context.students.Add(student);
                context.SaveChanges();
            }
        }

        public List<Student> SearchByStatus(string status)
        {
            using (var context = new StudentCollectionContext())
            {
                var FindStudent = context.students.Where(s => s.status == status).ToList();
                return FindStudent;
            }
             
        }

        public List<Student> Sort()
        {
            using (var context = new StudentCollectionContext())
            {
                return context.students.OrderBy(s => s.status == "Active" ? 0 : 1).ToList();
            }
        }

        public void Update(Student student)
        {
            using (var context = new StudentCollectionContext())
            {
                context.students.Update(student);
                context.SaveChanges();
            }
        }
    }
}
