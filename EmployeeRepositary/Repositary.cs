
using EmployeeEntity;
using System.Collections.Generic;
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
        
        public void Delete(int employeeId)
        {
            Employee employee = GetEmployeeById(employeeId);
            if (employee != null)
                employees.Remove(employee);
        }
  
        public void Update(Employee employee)
        {
            Employee employeeObject=employees.Find(id => id.employeeId == employee.employeeId);
            employeeObject.employeeName = employee.employeeName;
            employeeObject.employeeDepartment = employee.employeeDepartment;
        }
        public Employee GetEmployeeById(int userEmployeeId)
        {
            return employees.Find(id => id.employeeId == userEmployeeId);
        }
    }
}
