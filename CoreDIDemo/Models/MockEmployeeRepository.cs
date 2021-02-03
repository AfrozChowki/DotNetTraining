﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDIDemo.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
    {
        new Employee() { Id = 1, Name = "Afroz" },
        new Employee() { Id = 2, Name = "Chaitanya" },
        new Employee() { Id = 3, Name = "Kamal" },
        new Employee() { Id=4, Name ="Maneesha"}
    };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
