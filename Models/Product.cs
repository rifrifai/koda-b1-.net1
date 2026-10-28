
namespace ConsoleApp.Models;
public class Product
{
	private readonly string Name = string.Empty;
    private decimal Price { get; set; }
	private string? Desc { get; set; }
	public Product(string name, decimal price, string desc)
	{
		if(string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("Name is required!");
		}
		if(price <= 0)
		{
			throw new ArgumentException("Price must be greater than 0");
		}
		Name = name;
		Price = price;
		Desc = desc;
	}

	public override string ToString()
	{
		return $"Product: {Name} \nHarga: {Price} \nDesc: {Desc}";
	}
}