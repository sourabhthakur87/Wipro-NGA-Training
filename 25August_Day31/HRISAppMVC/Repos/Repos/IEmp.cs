using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib;

namespace Repos.Repos
{
    public interface IEmp
    {
        string AddEmployee(Employee emp);
        string EditEmployee(Employee emp);

        List<Employee> GetEmployees();
        string RemoveEmployee(int id);
    }
}
