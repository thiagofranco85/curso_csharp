using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterfaceContrato.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double paymentFee(double amount)
        {             
            return amount + (amount * 0.02);
        }

        public double interest(double amount, int months)
        {
            return amount + (amount * (months / 100.00));
        }
    }
}
