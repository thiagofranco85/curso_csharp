using System;

namespace BolsaEstudo.Entities
{
    class BolsaGraduacao : AbstractBolsa
    {
        public string Curso { get; set; } 

        public BolsaGraduacao(double valorIntegral, Escola escola, Aluno aluno, string curso) 
        : base( valorIntegral, escola, aluno)
        {
            this.Modalidade = Modalidade.Graduacao;
            this.Percentual = 30.00;
            this.Curso = curso;   
        }
        
    }
}