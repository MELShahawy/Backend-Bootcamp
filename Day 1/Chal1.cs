using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1Cha1
{
    internal class Chal1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Sign Up ");
            Console.WriteLine("Your Name: ");
            string name = Console.ReadLine();
            name=name.Trim();
            Console.WriteLine("Your Password: ");
            string passCode = Console.ReadLine();
            passCode=passCode.Trim();

            Console.WriteLine("To Log In Please enter your name and password");
            Console.WriteLine("Your Name: ");
            var name1 = Console.ReadLine();
            Console.WriteLine("Your Password: ");
            var passCode1 = Console.ReadLine();

            if (passCode == passCode1 && name == name1)
            {
                Console.WriteLine("Correct Log In");

            }
            else { Console.WriteLine("Wrong Name Or Passcode"); }

            Console.ReadLine(); 
        }
}}
