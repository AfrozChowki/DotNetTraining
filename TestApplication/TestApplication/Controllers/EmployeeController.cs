using System.Web.Http;
using TestApplication.Entities;

namespace TestApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET api/employee
        [HttpGet]
        public string Get(int id)
        {
            string result = string.Empty;
            // API showing Liskov substitution principle (LSP) example
            Employee employee;
            switch (id)
            {
                case 1:
                    employee = new ContractualEmployee
                    {
                        Id = 123,
                        Name = "Kamal",
                        Salary = 123456
                    };
                    break;
                case 2:
                    employee = new PermanentEmployee
                    {
                        Id = 124,
                        Name = "Maneesha",
                        Salary = 123457
                    };

                    // Interface segregation principle (ISP) example
                    PermanentEmployee permanentEmployee = (PermanentEmployee)employee;
                    result += permanentEmployee.GetEmployee(employee.Id) + " ";
                    break;
                default:
                    employee = new Employee();
                    break;
            }
            result += employee.AddNewEmployee(employee);

            return result;
        }
    }
}
