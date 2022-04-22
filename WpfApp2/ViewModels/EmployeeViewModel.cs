using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Models;

namespace WpfApp2.ViewModels
{
     class EmployeeViewModel
    {

        public IList<Employee> employees = new List<Employee>();
        public EmployeeViewModel()
        {
            employees.Add(new Employee() { Id = 1, Name = "Ali" , CellNo = "09243232232", Employeenum = 70 });
            employees.Add(new Employee() { Id = 2, Name = "Hassan", CellNo = "09243232232", Employeenum = 77 });
            employees.Add(new Employee() { Id = 3, Name = "Ahsan", CellNo = "09243232232", Employeenum =99 });
            employees.Add(new Employee() { Id = 4, Name = "Khan", CellNo = "09243232232", Employeenum = 10 });

        }



        public IList<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
    }
}
