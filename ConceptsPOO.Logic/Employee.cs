namespace ConceptsPOO.Logic
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Date? BornDate { get; set; }
        public Date? HireDate { get; set; }
        public bool IsActive { get; set; }
        public override string ToString()
        {
            return $"{Id}\t{FirstName} {LastName}\n\t" +
                   $"born Date .............: {BornDate,20}\n\t" +
                   $"hire ..................: {HireDate,20}\n\t" +
                   $"Is active .............: {IsActive,20 }";
        }
        public abstract decimal GetValueToPay();
    }
}
