namespace ConceptsPOO.Logic
{
    public class CommisionEmployee : Employee
    {
        private float _commisionPercentaje;
        private decimal _sales;

        public float CommisionPercentaje
        {
            get => _commisionPercentaje;
            set => _commisionPercentaje = ValidateCommisionPercentaje(value);
        }


        public decimal Sales
        {
            get => _sales;
            set => _sales = ValidateSales(value);
        }


        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommisionPercentaje * 0.88m;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Commision Percentaje is: {CommisionPercentaje,20:P2}\n\t" +
                   $"Sales value is ........: {Sales,20:C2}\n\t" +
                   $"Get value to pay.......: {GetValueToPay(),20:C2}";
        }

        private float ValidateCommisionPercentaje(float value)
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentException("The Commision Percentaje is not valid.");
            }
            return value;

        }
        private decimal ValidateSales(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentException("The Sales value is not valid.");
            }
            return value;

        }


    }
}
