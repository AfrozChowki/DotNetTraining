namespace TestApplication.Entities
{
    public class PermanentEmployee : Employee, IGetOperation
    {
        public override string AddNewEmployee(Employee employee)
        {
            return "Employee added from PermanentEmployee class.";
        }

        // Interface segregation principle (ISP) example
        public string GetEmployee(long id)
        {
            return "Here, get operation only available to permanent employee.";
        }
    }
}