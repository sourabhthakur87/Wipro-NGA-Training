using ModelsLib;
using Repos.Repos;

namespace Services
{
    public class DepartmentServices
    {
        private readonly IDept _dept;
        public DepartmentServices(IDept dept)
        {
            _dept = dept;
        }

        public string AddDepartment(Department dept)
        {
            string message = _dept.AddDept(dept);
            return message;

        }

        public List<Department> GetDepartment()
        {
            return _dept.GetDepartments();
        }

    }
}
