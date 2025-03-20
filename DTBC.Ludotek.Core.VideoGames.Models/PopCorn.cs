using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Models
{
	public class PopCorn
	{
		private bool estMange = false;
		public static int Compteur { get; set; }
		public PopCorn()
		{
			Compteur++;
		}

		public void Manger()
		{
			if (estMange)
			{
				throw new Exception("Le pop corn est déjà mangé");
			}
			estMange = true;
		}
	}
}
