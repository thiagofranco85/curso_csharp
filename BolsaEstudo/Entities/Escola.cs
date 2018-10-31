using System;

namespace BolsaEstudo.Entities
{
    class Escola
    {
        public string RazaoSocial { get; set; }
        public Modalidade[] Modalidade {get; set;}

        public Escola(string RazaoSocial, Modalidade[] Modalidade){
            this.RazaoSocial = RazaoSocial;
            this.Modalidade = Modalidade;
 
        }
    }
}