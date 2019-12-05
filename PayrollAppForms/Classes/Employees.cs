using System.Collections.Generic;

namespace PayrollAppForms.Classes
{
    class Employees
    {
        //storage for the employee list.
        private static List<Employee> employeeList = new List<Employee>();

        //proves public access to said employee list.
        public static List<Employee> EmployeeList 
            {
            get { return employeeList; }
            set { employeeList.Add(new Employee()); }
        }
    }
}
