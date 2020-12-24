using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    public class PersonData
    {
        public static Person GetPersonData()
        {
            Person person = new Person();

            Console.Write("Enter your firstname: ");
            person.firstName = Console.ReadLine();

            Console.Write("Enter your lastname: ");
            person.lastName = Console.ReadLine();

            return person;

        }
    }
}
