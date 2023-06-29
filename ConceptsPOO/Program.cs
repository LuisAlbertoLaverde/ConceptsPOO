
using ConceptsPOO.Logic;

try
{
    var date1 = new Date();
    var date2 = new Date(2023,2,14);
    var date3 = new Date()  
    {
        Year=2024, 
        Month=2, 
        Day=1 
    };
    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}