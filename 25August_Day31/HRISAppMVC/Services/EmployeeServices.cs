using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib;
using Repos.Repos;

namespace Services
{
    public class EmployeeServices
    {
        private readonly IEmp _emp;
        public EmployeeServices(IEmp emp)
        {
            _emp = emp;
        }

        public string AddEmployee(Employee emp)
        {
            string message = _emp.AddEmployee(emp);
            return message;
        }

        public List<Employee> GetEmployee()
        {
            return _emp.GetEmployees();
        }
    }
}
