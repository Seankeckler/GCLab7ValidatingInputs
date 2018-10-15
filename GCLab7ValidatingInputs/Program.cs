using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GCLab7ValidatingInputs
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a name to be validated: ");
            string enteredName = Console.ReadLine();
            bool nameValidated = ValidateName(enteredName);

            if (nameValidated == true)
            {
                Console.WriteLine("That is a valid name");
            }
            else
            {
                Console.WriteLine("That name is not valid");
            }
            Console.WriteLine("Enter an email to be verified: ");




            Console.ReadKey();
        }

        public static bool ValidateName(string name)
        {
            Regex n = new Regex("^[a-zA-Z ]+$");
            if (n.IsMatch(name))
            {
                return true;
            }
            else
                return false;
        }
       
    }
}
