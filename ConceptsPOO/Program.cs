
using ConceptsPOO.Logic;

try
{
    var employee1 = new SalaryEmployee
    {
        Id = 1010,
        FirstName = "Alberto",
        LastName = "Laverde",
        BornDate = new(2001, 12, 2),
        HireDate = new(2022, 12, 3),
        IsActive = true,
        Salary = 1400000M,
    };
    var employee2 = new HourlyEmployee
    {
        Id = 2020,
        FirstName = "Sara",
        LastName = "Laverde",
        BornDate = new(2011, 10, 22),
        HireDate = new(2022, 10, 3),
        IsActive = true,
        WorkingHours = 123.5f,
        HourValue = 120000M
    };
    var employee3 = new CommisionEmployee
    {
        Id = 3030,
        FirstName = "Ernest",
        LastName = "Hemingway",
        BornDate = new(1985, 6, 11),
        HireDate = new(2021, 9, 4),
        IsActive = true,
        CommisionPercentaje = 0.05f,
        Sales = 200000000m
    };
    var employee4 = new BaseCommisionEmployee
    {
        Id = 4040,
        FirstName = "Harold",
        LastName = "Heminy",
        BornDate = new(1976, 8, 12),
        HireDate = new(2022, 8, 14),
        IsActive = true,
        CommisionPercentaje = 0.025f,
        Sales = 40000000m,
        Salary = 620000m,
    };
    decimal PayRoll = 0;
    Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4 };
    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        PayRoll+=employee.GetValueToPay();
    }
    Console.WriteLine($"                                 ====================");
    Console.WriteLine($"Pay roll                         {PayRoll,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}