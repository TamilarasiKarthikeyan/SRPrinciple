using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    public class GenerateUserData
    {
        public static void SaveUserData(Person person)
        {
            Console.WriteLine($"Your username is {person.firstName.Substring(0, 1)} {person.lastName}");
            
        }
    }
}
