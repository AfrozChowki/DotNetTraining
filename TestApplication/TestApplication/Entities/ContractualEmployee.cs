namespace TestApplication.Entities
{
    public class ContractualEmployee : Employee
    {
        public override string AddNewEmployee(Employee employee)
        {
            return "Employee added from Contractual Employee class";
        }
    }
}