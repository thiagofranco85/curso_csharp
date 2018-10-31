using System;

namespace BolsaEstudo.Entities
{
    class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; } 

        public Aluno(string Nome, DateTime DataNascimento){
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
        }
    }
}