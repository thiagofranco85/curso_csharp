namespace BulkSql.Entities
{
    class AbstractSql
    {
        private string[] queries{get; set;}

        public AbstractSql(string[] queries){
            this.queries = queries;
        }
        
        public string convertMultipleInserts(){

            //pega quantidade de linhas
            int qtdeLinhas = this.queries.Length;

            // pega a base da query insert
            int posicaoSegundoParenteseAberto = this.queries[0].IndexOf( "(" , this.queries[0].IndexOf(')') + 1 );
            string baseQuery = this.queries[0].Substring(0, posicaoSegundoParenteseAberto); 

            int posicaoInicialValores  = baseQuery.Length;
            
            string queryFinal = baseQuery;
            string[] valores = new string[qtdeLinhas];
            
            for (int i = 0; i < qtdeLinhas; i++)
            {
                int posicaoFinalDinamicaQuery =  this.queries[i].Length;
                //pega os valores
                valores[i] = this.queries[i].Substring(posicaoInicialValores, posicaoFinalDinamicaQuery - posicaoInicialValores);
            }
            //junta a base da query com os valores
            queryFinal += string.Join(',', valores);

            return queryFinal;
        }

        public string convertMultipleUpdates(){

            //pega quantidade de linhas
            int qtdeLinhas = this.queries.Length;

            // pega a base da query update
            int posicaoSet = this.queries[0].ToLower().IndexOf("set") + 3;
            string baseQuery = this.queries[0].Substring(0, posicaoSet);

            for (int i = 0; i < qtdeLinhas; i++)
            {
                //pega colunas da query update
                
            }

            

            return baseQuery;

        }
 
    }
}