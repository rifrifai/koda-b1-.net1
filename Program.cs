using ConsoleApp.Models;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("==========================");
		Console.WriteLine("     KODA BANKING APP     ");
		Console.WriteLine("==========================");

		Account acc1 = new("AC001", "Budi", 10_000);
		Console.WriteLine(acc1);
	}
}