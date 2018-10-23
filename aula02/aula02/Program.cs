using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;
            int N;

            N = int.Parse( Console.ReadLine() );
            mat = new int[N, N];

            for (int i=0; i<N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');

                for(int j=0; j< linha.Length; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("Diagonal Principal");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(mat[i,i] + " " );
            }

            Console.ReadLine();


        }
    }
}
