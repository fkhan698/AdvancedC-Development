using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    class PersonValidator
    {
        public static bool Validate(Person person)
        {
            // Checks to be sure the first and last name are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError(person.FirstName);
                Console.ReadLine();
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError(person.LastName);
                Console.ReadLine();
                return false;
            }

            return true;
        }
    }
}
