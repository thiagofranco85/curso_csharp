using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterfaceContrato.Services
{
    interface IOnlinePaymentService
    {
        double paymentFee(double amount);
        double interest(double amount, int months);
    }
}
