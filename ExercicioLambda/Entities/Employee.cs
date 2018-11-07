using System;

namespace ExercicioLambda.Entities{
    class Employee{
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string Name, string Email, double Salary){
            this.Name = Name;
            this.Email = Email;
            this.Salary = Salary;
        }
    }
}