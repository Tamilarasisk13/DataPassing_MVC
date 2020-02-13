
using EmployeeEntity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRepositary
{
    public class Repositary
    {
        public static List<Employee> employees = new List<Employee>();
        static Repositary()
        {
            employees.Add(new Employee { employeeId = 1, employeeName = "Tamil", employeeDepartment = "Trainee" });
            employees.Add(new Employee { employeeId = 2, employeeName = "Arasi", employeeDepartment = "Developer" });
            employees.Add(new Employee { employeeId = 3, employeeName = "Kavi", employeeDepartment = "Tester" });
        }
        public static IEnumerable<Employee> GetEmployee()
        {
            return employees;
        }
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
