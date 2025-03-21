using System.Diagnostics;
using TheDelegates;

Developper dev = new();
LeadTech leadTech = new();

ExecuteCode executeCode = dev.Create;

ExecuteCode bis = (int reviewId) =>
{
	Console.WriteLine("Dos");
	return new Code("");
};

ExecuteCode unDosTres = executeCode + bis;

unDosTres += (int reviewId) =>
{
	Console.WriteLine("Tres");
	return new Code("Tres");
};

var result = leadTech.Review(unDosTres);

Console.WriteLine($"{result.Success}");