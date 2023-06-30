namespace ConceptsPOO.Logic
{
    public class BaseCommisionEmployee : CommisionEmployee
    {
        private decimal _salary;
        public decimal Salary
        {
            get => _salary;
            set => _salary = ValidateSalary(value);
        }
        public override string ToString()
        {
            return $"{Id}\t{FirstName} {LastName}\n\t" +
                   $"born Date .............: {BornDate,20}\n\t" +
                   $"hire ..................: {HireDate,20}\n\t" +
                   $"Is active .............: {IsActive,20}\n\t" +
                   $"Commision Percentaje is: {CommisionPercentaje,20:P2}\n\t" +
                   $"Base Salary is ........: {Salary,20:C2}\n\t" +
                   $"Sales value is ........: {Sales,20:C2}\n\t" +
                   $"Get value to pay.......: {GetValueToPay(),20:C2}";
        }
        public override decimal GetValueToPay()
        {
            var salary = base.GetValueToPay() + Salary;
            if (salary < 1160000)
            {
                return 1160000;
            }
            return salary;
        }
        private decimal ValidateSalary(decimal value)
        {
            if (value < 600000)
            {
                throw new ArgumentException("The salary base is not valid.");
            }
            return value;
        }

    }
}
