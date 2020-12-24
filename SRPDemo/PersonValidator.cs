using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.firstName))
            {
                StandardMessages.DisplayErrorMessages("first name");
                
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.lastName))
            {
                StandardMessages.DisplayErrorMessages("last name");

                return false;
            }

            return true;
        }
    }
}
