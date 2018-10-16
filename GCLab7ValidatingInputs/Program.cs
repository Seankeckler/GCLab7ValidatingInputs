using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.WriteLine("First Name or Last Name or both, make sure to capitalize.");
            Console.Write("Enter a name to be validated: ");
            string enteredName = Console.ReadLine();
            bool nameValidated = ValidateName(enteredName);
            bool nameValidatedPt2 = ValidateNamePt2(enteredName);

            if (nameValidated == true && nameValidatedPt2 == true )
            {
                Console.WriteLine("That is a valid name");
            }
            else
            {
                Console.WriteLine("That name is not valid");
            }


            Console.WriteLine("\n abc@emailprovider.com");
            Console.Write("Enter an email to be verified: ");
            string enteredEmail = Console.ReadLine();
            bool emailValidated = ValidateEmail(enteredEmail);

            if (emailValidated == true)
            {
                Console.WriteLine("That is a valid Email");
            }
            else
            {
                Console.WriteLine("That Email is not valid");
            }

            Console.WriteLine("\n 10 digits, 555-555-5555 or 5555555555");
            Console.Write("Enter a phone number to be validated: ");
            string phoneNumber = Console.ReadLine();
            bool phoneValidated = ValidatePhone(phoneNumber);
            if (phoneValidated == true)
            {
                Console.WriteLine("That is a valid Phone Number.");
            }
            else
            {
                Console.WriteLine("That phone number is not valid.");
            }

            Console.WriteLine("\n dd/mm/yyyy");
            Console.Write("Enter a date to be validated: ");
            ValidateDate(Console.ReadLine());

            Console.ReadKey();
        }
        
        public static bool ValidateNamePt2(string nameAgain)
        {
            if (string.IsNullOrEmpty(nameAgain) || !char.IsUpper(nameAgain[0] )|| nameAgain.Length > 30 )
            {
                return false;
            }
            else
            {
                return true;
            }
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

        public static bool ValidateEmail(string email)
        {
            Regex emailExpression = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (emailExpression.IsMatch(email)) 
            {
                return true;
            }
            else
                return false;

        }

        public static bool ValidatePhone(string phone)
        {
            Regex Phone = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (Phone.IsMatch(phone))
            {
                return true;
            }
            else
                return false;
        }

        public static void ValidateDate(string date)
        {
            DateTime validDate;
            if (DateTime.TryParse(date, out validDate))
            {
                string.Format("{0:d/MM/yyyy}", validDate);
                Console.WriteLine("That is a valid date");
            }
            else
            {
                Console.WriteLine("That date is not valid");
            }
        }
       
    }
}
