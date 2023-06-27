using ConceptsPOO;

try
{
    var date1 = new Date() { Year = 2028, Month = 2, Day = 29 };
    var date2 = new Date() { Year = 1974, Month = 12, Day = 14 };
    Console.WriteLine(date1);
    Console.WriteLine(date2);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}