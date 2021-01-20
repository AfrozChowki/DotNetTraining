using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStreamDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Asyncronous stream demo!");
            //await ShowPersonDataAsync();

            Console.WriteLine("Normal stream demo!");
            ShowPersonData();
        }

        #region Asyncronous stream demo methods
        public static async IAsyncEnumerable<Person> GetPersonDataAsync()
        {
            PersonRepository personRepository = new PersonRepository();
            var persons = personRepository.GetPersonData();
            foreach (var person in persons)
            {
                await Task.Delay(1000);
                yield return person;
            }
        }

        public static async Task ShowPersonDataAsync()
        {
            await foreach (var person in GetPersonDataAsync())
            {
                Console.WriteLine("{0} {1} {2}", person.FirstName, person.LastName, person.BirthDate);
                Console.WriteLine("----------------------------------");
            }
        }
        #endregion

        #region Normal stream demo methods
        public static async Task<IEnumerable<Person>> GetPersonData()
        {
            PersonRepository personRepository = new PersonRepository();
            var persons = personRepository.GetPersonData();

            List<Task<Person>> listOfTasks = new List<Task<Person>>();

            foreach (var person in persons)
            {
                listOfTasks.Add(GetPersonTaskResult(person));
            }

            return await Task.WhenAll<Person>(listOfTasks);
        }

        public static Task<Person> GetPersonTaskResult(Person person)
        {
            Task.Delay(1000);
            return Task.FromResult(person);
        }

        public static async void ShowPersonData()
        {
            var personData = await GetPersonData();
            foreach (var person in personData)
            {
                Console.WriteLine("{0} {1} {2}", person.FirstName, person.LastName, person.BirthDate);
                Console.WriteLine("----------------------------------");
            }
        }
        #endregion
    }
}
