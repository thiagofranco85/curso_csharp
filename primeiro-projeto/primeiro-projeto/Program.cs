using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade, soma, cont;

            soma = 0;
            cont = 0;
            idade = 0;

            for (int i = 0; i < 5; i++)
            {
                idade = int.Parse(Console.ReadLine());

                soma += idade;
                cont++;
            }

            Console.WriteLine("SOma das idade = " + soma);
            Console.ReadLine();
        }
    }
}
