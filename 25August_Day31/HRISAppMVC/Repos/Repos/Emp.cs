using ModelsLib;

namespace Repos.Repos
{
    public class Emp : IEmp
    {

        private readonly RepoContext _context;
        public Emp(RepoContext context)
        {
            _context = context;
        }
        public string AddEmployee(Employee emp)
        {
            try
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();
                return "Employee" + emp.Name + " Added Success";
            }
            catch (Exception ex)
            {
                return "Employee Addition Failed: " + ex.Message;
            }
        }

        public string EditEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public string RemoveEmployee(int id)
        {
            throw new NotImplementedException();
        }
    }
}
