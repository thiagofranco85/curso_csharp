using System;
using BulkSql.Entities;

namespace bulkSql
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[3];
            
            a[0] = "insert into cliente (id, nome, data) values (123, 'Thiago Franco', '1985-03-23')";
            a[1] = "insert into cliente (id, nome, data) values (124, 'Leandro Garcia', '1960-03-23')";
            a[2] = "insert into cliente (id, nome, data) values (125, 'Diogo Santos', '1990-03-23')";
 
            AbstractSql sql = new AbstractSql(a);
            string retorno = sql.convertMultipleInserts();

            System.Console.WriteLine(retorno);



            string[] b = new string[3];
            
            b[0] = "update cliente set nome = 'thiago', data = '1985-03-23' where id = 123";
            b[1] = "update cliente set nome = 'diogo', data = '1985-03-23' where id = 124";
            b[2] = "update cliente set nome = 'leandro', data = '1985-03-23' where id = 125";

            AbstractSql sql2 = new AbstractSql(b);
            string retorno2 = sql2.convertMultipleUpdates();

            System.Console.WriteLine(retorno2);
        }
    }
}
