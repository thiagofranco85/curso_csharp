using System;
using ExercicioInterfaceContrato.Entities;
using ExercicioInterfaceContrato.Services;
using System.Globalization;

namespace ExercicioInterfaceContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datacontrato = DateTime.ParseExact("25/06/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Contract contract = new Contract(8028, datacontrato, 600.00);


            ContractService contractService = new ContractService( new PaypalService() );

            contractService.processContract(contract, 3);

            //Console.WriteLine(contract.ToString());

            string retorno = "";
            for (int i = 0; i < contract.Installment.Length; i++)
            {
                retorno = contract.Installment[i].DueDate + " " + contract.Installment[i].Amount;
                Console.WriteLine(retorno);

                Console.ReadLine();
            }

            
        }
    }
}
