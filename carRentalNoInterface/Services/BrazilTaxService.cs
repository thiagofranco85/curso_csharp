using System; 

namespace Course.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            double retorno = amount * 0.15;

            if ( amount <= 100)
            {
                retorno =  amount * 0.2;
            }

            return retorno;
        }
    }
}
