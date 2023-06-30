namespace ConceptsPOO.Logic
{
    public class HourlyEmployee : Employee
    {
        private decimal _hourValue;
        private float _workingHours;

        public decimal HourValue
        {
            get => _hourValue;
            set => _hourValue = ValidateHourValue(value);
        }
        public float WorkingHours
        {
            get => _workingHours;

            set => _workingHours = ValidateWorkingHours(value);
        }
        public override decimal GetValueToPay()
        {
            return HourValue * (decimal)0.88 * (decimal)WorkingHours;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Working hour is........: {WorkingHours,20:N2}\n\t" +
                   $"Hour value is .........: {HourValue,20:C2}\n\t" +
                   $"Get value to pay.......: {GetValueToPay(),20:C2}";
        }

        private float ValidateWorkingHours(float value)
        {
            if (value < 0 || value > 240)
            {
                throw new ArgumentException("The working hours is not valid.");
            }
            return value;
        }
        private decimal ValidateHourValue(decimal value)
        {
            if (value < 30000)
            {
                throw new ArgumentException("The hour value is not valid.");
            }
            return value;

        }


    }
}
