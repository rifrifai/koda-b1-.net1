
namespace ConsoleApp.Models;
public class Product(string name, decimal price, string desc)
{
    private string Name { get; set; } = name;
    private decimal Price { get; set; } = price;
    private string Desc { get; set; } = desc;

    public override string ToString()
    {
        return $"Product: {Name} - Harga: {Price} - Desc: {Desc}";
    }
}