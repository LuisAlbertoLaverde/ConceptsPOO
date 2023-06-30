namespace ConceptsPOO.Logic
{
    public class SalaryEmployee : Employee
    {
        private decimal _salary;
        public decimal Salary
        {
            get => _salary;
            set => _salary = ValidateSalary(value);
        }


        public override decimal GetValueToPay()
        {
            return Salary * (decimal)0.88;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"salary is .............: {Salary,20:C2}\n\t" +
                   $"value to pay...........: {GetValueToPay(),20:C2}";
        }
        private decimal ValidateSalary(decimal value)
        {
            if (value < 1160000)
            {
                throw new ArgumentException("The salary is less than minimun.");
            }
            return value;
        }

    }
}
