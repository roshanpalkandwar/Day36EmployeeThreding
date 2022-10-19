namespace Day36EmployeeThreding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Payroll Syatem using thread");
            AddEmployeeDetails addEmployeeDetails = new AddEmployeeDetails();
            addEmployeeDetails.AddingEmployees();
        }
    }
}