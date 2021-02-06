namespace TestApplication.Entities
{
    public class Employee : IAddOperation
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public virtual string AddNewEmployee(Employee employee)
        {
            // logic to add employee to database
            return "Added employee from base class.";
        }
    }
}