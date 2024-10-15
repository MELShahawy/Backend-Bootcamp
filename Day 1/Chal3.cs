using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1Cha3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1;
            string input2;
            Console.WriteLine("Enter The First Number:");
            input1 = Console.ReadLine();
            Console.WriteLine("Enter The First Number:");
            input2 = Console.ReadLine();
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);
            int sum;
            int oper;
            Console.WriteLine(" Please Choose THe Operator From  1 for +, 2 for -, 3 for *, 4 for / ");
            string ch = Console.ReadLine();
            oper = int.Parse(ch);

            switch (oper)
            {
                case 1:
                    sum = num1 + num2;
                    Console.WriteLine($"The Result Is {sum}");
                    break;
                case 2:
                    sum = num1 - num2;
                    Console.WriteLine($"The Result Is {sum}");
                    break;
                case 3:
                    sum = num1 * num2;
                    Console.WriteLine($"The Result Is {sum}");
                    break;
                case 4:
                    sum = num1 / num2;
                    Console.WriteLine($"The Result Is {sum}");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }

            Console.ReadLine();

        }
    }
}
