using System;

namespace BolsaEstudo.Entities
{
    class BolsaEnsinoBasico : AbstractBolsa
    {
        public string Segmento { get; set; }
        public string Serie { get; set; } 

        public BolsaEnsinoBasico(double valorIntegral, Escola escola, Aluno aluno, string segmento, string serie) 
        : base( valorIntegral, escola, aluno)
        {
            this.Modalidade = Modalidade.EnsinoBasico;
            this.Percentual = 50.00;
            this.Segmento = segmento;
            this.Serie = serie;
        }
    }
}