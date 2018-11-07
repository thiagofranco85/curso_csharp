using System;
using ExercicioLambda.Entities;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace ExercicioLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader sr  = new StreamReader( "employee.csv")){
                string linha;

                List<Employee> lista = new List<Employee>();
            
                while ((linha = sr.ReadLine()) != null) 
                {
                    string[] arr = linha.Split(";");                     
                    lista.Add( new Employee(arr[0], arr[1], double.Parse(arr[2]) ) );
                     
                }
                double nivelSalarial = 3000.00;

                IEnumerable<string> nomes = lista.Where( x => x.Salary > nivelSalarial).Select( s => s.Name );

                System.Console.WriteLine("Salarios maior que " + nivelSalarial);
                foreach (var nome in nomes)
                {
                    System.Console.WriteLine(nome);
                }

                char letra = 'M';

                double soma = lista.Where(x => x.Name[0] == letra).Sum(x => x.Salary);

                System.Console.WriteLine("Soma Salarios quem comecam com a letra "+letra+ ": " + soma);
            }

            
        }
    }
}
