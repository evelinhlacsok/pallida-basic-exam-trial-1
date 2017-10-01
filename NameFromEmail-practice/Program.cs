using System;
using System.Collections.Generic;

namespace NameFromEmail_practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a function that takes an email address as input in the following format: firstName.lastName@exam.com
            //and returns a string that represents the user name in the following format: lastName firstName
            //example: "elek.viz@exam.com" for this input the output should be: "Viz Elek"
            //accents does not matter 
            Console.WriteLine(NameFromEmail("elek.viz@exam.com"));
            Console.ReadLine();
        }

        private static string NameFromEmail(string email)
        {
            string firstname = email.Substring(0, email.IndexOf('.'));
            string lastname = email.Substring(email.IndexOf('.') + 1, email.IndexOf('.')-1);

            return lastname.Substring(0, 1).ToUpper() + lastname.Substring(1) + " " + 
                   firstname.Substring(0, 1).ToUpper() + firstname.Substring(1);
        }
    }
}