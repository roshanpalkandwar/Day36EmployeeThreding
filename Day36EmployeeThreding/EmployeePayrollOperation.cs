using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36EmployeeThreding
{
    public class EmployeePayrollOperation
    {
        List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
        public void AddEmployeeToPayroll(List<EmployeeDetails> employeeDetails)
        {
            employeeDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added : " + employeeData.EmployeeName);
                this.AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee added : " + employeeData.EmployeeName);

            });
            Console.WriteLine(this.employeeDetails.ToString());
        }

        public void AddEmployeeToPayrollWithThread(List<EmployeeDetails> employeeDetails)
        {
            employeeDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added : " + employeeData.EmployeeName);
                    this.AddEmployeePayroll(employeeData);
                    Console.WriteLine("Employee added : " + employeeData.EmployeeName);
                });
                thread.Start();
            });
            Console.WriteLine(this.employeeDetails.Count());
        }

        public void AddEmployeePayroll(EmployeeDetails emp)
        {
            employeeDetails.Add(emp);
        }

        public int Count()
        {
            return this.employeeDetails.Count();
        }
    }
}
