using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	class Cours
	{
		public static void RechercherCours(int numeroCoursRechercher)
		{
			foreach (Cours cours in Program.ListDesCours)
			{
				if (cours.NumeroCours == numeroCoursRechercher)
				{
					Console.WriteLine(cours.ToString());
				}
			}
		}
	}
}
