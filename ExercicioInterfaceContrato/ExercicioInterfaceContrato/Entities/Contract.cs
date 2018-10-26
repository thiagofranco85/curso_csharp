using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterfaceContrato.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double Value { get; private set; }
        public Installment[] Installment { get; set; }



        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            string retorno = "";
            for (int i = 0; i < this.Installment.Length; i++)
            {
                retorno += Installment[i].DueDate + " " + Installment[i].DueDate.ToString();
            }
            return retorno;
        }
    }
}
