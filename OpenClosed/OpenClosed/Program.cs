using System;
using System.Collections.Generic;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel> { 
                new PersonModel {FirstName = "John", LastName = "Doe"},
                new PersonModel {FirstName = "Bob", LastName = "Smith"},
                new PersonModel { FirstName = "Sue", LastName = "Roman"}
            
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            Accounts accountProcessor = new Accounts();

            foreach(var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress}");
            }

            Console.ReadLine();
        }
    }

}
