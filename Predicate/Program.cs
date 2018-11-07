using System;
using Course.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Course {
    class Program {
        
        static void Main(string[] args) {


            
            IEnumerable<int> i = new int[]{1,2,3,4};

            foreach(int num in i){
                System.Console.WriteLine(num);
            }
 
  

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            IEnumerable<Product> lista = list.Where( x => ProductTest(x,100) );

            Console.WriteLine(lista);
            //list.RemoveAll(ProductTest);
            foreach (Product p in lista) {
                Console.WriteLine(p);
            }
        }

          static public bool ProductTest(Product p, double valor){
            return p.Price >= valor;
        }
    }
}
