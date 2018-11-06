using System;

namespace BolsaEstudo.Entities
{
    abstract class AbstractBolsa
    {
        public double Percentual { get;  protected set; }
        public double ValorIntegral {get; set;}
        public double ValorFinal {get; protected set;}

        private Modalidade modalidade;
        public Modalidade Modalidade {
            get{ return modalidade;} 
            protected set{ 
                modalidade = value;

                if( ! verificaModalidade() )  throw new Exception(message: "A Escola não possui a modalidade " + value );
                
            }
        }
        public Escola Escola {get;set;}
        public Aluno Aluno {get;set;}

        public AbstractBolsa(double valorIntegral, Escola escola, Aluno aluno){
            this.ValorIntegral = valorIntegral; 
            this.Escola = escola;
            this.Aluno = aluno;  
        }

        public double calculaValorFinal(){ 

            return ValorIntegral - ( ValorIntegral * (Percentual/100.00) );
        }
 

        public bool verificaModalidade(){ 
            bool retorno = false; 
            for (int i = 0; i < Escola.Modalidade.Length; i++)
            { 
                //System.Console.WriteLine( Modalidade + " - " + this.Modalidade + " - " + this.Modalidade.Equals( Escola.Modalidade[i]) );
                if( this.Modalidade.Equals( Escola.Modalidade[i]) ){
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        
    }
}