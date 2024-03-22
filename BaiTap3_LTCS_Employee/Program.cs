using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3_LTCS_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Employee> employees = Employee.GetEmployees();

            //cau1
            Console.WriteLine("Maximum Salary: " + employees.Max(e => e.Salary));
            Console.WriteLine("Min Salary: " + employees.Min(e => e.Salary));
            Console.WriteLine("Average Salary: " + employees.Average(e => e.Salary));

            //cau2
            // group join
            var employeesByDepartment = Department.GetDepartments()
                .GroupJoin(Employee.GetEmployees(),
                    d => d.ID,
                    e => e.DepartmentID,
                    (d, eGroup) => new
                    {
                        Department = d,
                        Employee = eGroup
                    });

            foreach (var department in employeesByDepartment)
            {
                Console.WriteLine(department.Department.Name);
                foreach (var employee in department.Employee)
                {
                    Console.WriteLine(" " + employee.Name);
                }
            }
                Console.WriteLine();
            }

            // left outer join
            var result = Employee.GetEmployees()
                .GroupJoin(Department.GetDepartments(),
                    e => e.DepartmentID,
                    d => d.ID,
                    (e, dGroup) => new
                    {
                        employeeName = e.Name,
                        DepartmentName = dGroup.FirstOrDefault()?.Name ?? "No Department"
                    });

            foreach (var employee in result)
            {
                Console.WriteLine("{0}-{1}", employee.employeeName, employee.DepartmentName);
            }
            Console.WriteLine();

            // right outer join 
            var result2 = Department.GetDepartments()
                .GroupJoin(Employee.GetEmployees(),
                    d => d.ID,
                    e => e.DepartmentID,
                    (d, eGroup) => new
                    {
                        DepartmentName = d.Name,
                        EmployeeName = eGroup.FirstOrDefault()?.Name ?? "No Employee"
                    });

            foreach (var item in result2)
            {
                Console.WriteLine("{0}-{1}", item.EmployeeName, item.DepartmentName);
            }
            Console.WriteLine();

            //cau3
            var maxAge = employees.Max(e => (DateTime.Now - e.Birthday).Days / 365);
            Console.WriteLine($"Max age: {maxAge} years");

            var minAge = employees.Min(e => (DateTime.Now - e.Birthday).Days / 356);
            Console.WriteLine($"Min age: {minAge} years");
        }
    }
}
