using System.Collections.Generic;
using System.Text.Json;

namespace AsynchronousStreamDemo
{
    public class PersonRepository
    {
        const string PersonData = "{\"Persons\":[{\"FirstName\":\"Robert\",\"LastName\":\"Kanasz\",\"BirthDate\":\"1985-08-19T00:00:00\",\"Height\":168,\"Weight\":71},\r\n{\"FirstName\":\"John\",\"LastName\":\"Doe\",\"BirthDate\":\"1981-09-25T00:00:00\",\"Height\":189,\"Weight\":80},\r\n{\"FirstName\":\"Jane\",\"LastName\":\"Doe\",\"BirthDate\":\"1989-12-01T00:00:00\",\"Height\":164,\"Weight\":45}]}";

        public List<Person> GetPersonData()
        {
            var dbResponse =  JsonSerializer.Deserialize<PersonDBInfo>(PersonData);
            return dbResponse.Persons;
        }
    }

    public class PersonDBInfo
    {
        public List<Person> Persons { get; set; }
    }
}
