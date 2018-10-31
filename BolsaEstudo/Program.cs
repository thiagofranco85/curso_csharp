using System;
using BolsaEstudo.Entities;

namespace BolsaEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Thiago Franco", DateTime.Parse("1985-03-23") );

            Modalidade[] modalidade = new Modalidade[2];
            modalidade[0] = Modalidade.EnsinoBasico;
            modalidade[1] = Modalidade.CursoTecnico;

            
            Escola escola = new Escola("SMCE", modalidade);
            
            //AbstractBolsa bolsa = new BolsaEnsinoBasico(1200.00, escola, aluno, "Ensino Fundamental", "1");
           // double valorFinal = bolsa.calculaValorFinal();

            try
            {
                BolsaGraduacao bolsa = new BolsaGraduacao(1000.00 , escola, aluno, "Direito");
                double valorFinal = bolsa.calculaValorFinal();

                Console.WriteLine("Bolsa " + bolsa.Modalidade +": " + valorFinal);
            }
            catch (System.Exception e)
            {
                
                System.Console.WriteLine( e.Message );
            }

            System.Console.WriteLine("final");

        }
    }
}
