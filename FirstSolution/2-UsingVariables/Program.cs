using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_UsingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Second Project - Using Variables");

            int idade;

            idade = 33;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("The execution ends here. Press Enter to Exit...");
            Console.ReadLine();
        }
    }
}
