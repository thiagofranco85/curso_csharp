using System.Globalization;

namespace Course.Entities
{
    class Invoice{
       public double BasicPayment { get; set; }
       public double Tax { get; set; }

       public Invoice(double basicPayment, double tax){
           this.BasicPayment = basicPayment;
           this.Tax = tax;
       }


       public double TotalPayment{
           get { return TotalPayment + Tax; }
       }

       public override string ToString(){
           return "Basic Payment: " + BasicPayment.ToString('F2', CultureInfo.InvariantCulture) +
           "\nTax: " + Tax.ToString('F2', CultureInfo.InvariantCulture) +
            "\n Total Payment: " + TotalPayment.ToString('F2', CultureInfo.InvariantCulture)
       }
    }
}