using System;
using System.Collections.Generic;
using ExercicioInterfaceContrato.Entities;

namespace ExercicioInterfaceContrato.Services
{
    class ContractService
    {
        public IOnlinePaymentService onlinePaymentService { get; set; }

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            this.onlinePaymentService = onlinePaymentService;
        }

        public void processContract(Contract contract, int months)
        {
            double parcelaSemJuros = contract.Value / months;
            DateTime dataInicial = contract.Date;

            Installment[] arr = new Installment[months];

            for (int i = 1; i <= months; i++)
            {
                DateTime proximaData = dataInicial.AddMonths(i);

                double valorComJurosMensal = this.onlinePaymentService.interest(parcelaSemJuros, i);
                double valorComTaxaServico = this.onlinePaymentService.paymentFee(valorComJurosMensal);
           
                Installment installment = new Installment(proximaData, valorComTaxaServico);
                                
                arr[i - 1] = installment;

                contract.Installment = arr;

            }
        }
    }
}
