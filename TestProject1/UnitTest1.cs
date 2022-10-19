using Day36EmployeeThreding;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEnteries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Bruce", PhoneNumber: "1234567890", Address: "nashik", Department: "HR", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Wayne", PhoneNumber: "1234567890", Address: "nashik", Department: "Manager", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Peter", PhoneNumber: "1234567890", Address: "nashik", Department: "Sales", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Rita", PhoneNumber: "1234567890", Address: "nashik", Department: "HR", Gender: 'F', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Riya", PhoneNumber: "1234567890", Address: "nashik", Department: "HR", Gender: 'F', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Ajay", PhoneNumber: "1234567890", Address: "nashik", Department: "Manager", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Vijay", PhoneNumber: "1234567890", Address: "nashik", Department: "Manager", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Banner", PhoneNumber: "1234567890", Address: "nashik", Department: "Sales", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 9, EmployeeName: "Joe", PhoneNumber: "1234567890", Address: "nashik", Department: "Sales", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 10, EmployeeName: "Doe", PhoneNumber: "1234567890", Address: "nashik", Department: "Manager", Gender: 'M', BasicPay: 10000, Deduction: 5000, TaxablePay: 2000, Tax: 1000, NetPay: 500, City: "nashik", Country: "India"));


            EmployeePayrollOperation employeePayrollOperation = new EmployeePayrollOperation();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperation.AddEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Dureation without thread : " + (stopDateTime - startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            employeePayrollOperation.AddEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Dureation without thread : " + (stopDateTimeThread - startDateTimeThread));
        }
    }
    
    
}