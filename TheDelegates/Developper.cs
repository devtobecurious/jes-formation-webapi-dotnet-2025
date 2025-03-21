using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDelegates
{
	/// <summary>
	/// Contrat de méthode pour tout retour de Code
	/// </summary>
	/// <returns></returns>
	public delegate Code ExecuteCode(int i);

	public record Code(string Content);

	public class Developper
	{
		public Code Create(int i) 
		{
			Console.WriteLine("un");
			return new Code("const code => coucou;");
		}
	}

	public class LeadTech
	{
		public (bool Success, string ErrorMessage) Review(ExecuteCode? executeCode)
		//public (bool Success, string ErrorMessage) Review(Func<int, Code>? executeCode)
		{
			Console.WriteLine("J'ouvre mon gitlab, pépere");


			Code? code = executeCode?.Invoke(12);

			return (true, "Youpi, t'es un bon toi !");
		}
	}
}
