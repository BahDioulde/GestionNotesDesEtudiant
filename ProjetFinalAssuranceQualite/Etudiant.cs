using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	class Etudiant
	{
		public static void RechercheEtudiant(int numeroEtudiantRechercher)
		{
			foreach (Etudiant etudiant in Program.ListEtudiants)
			{
				if (etudiant.NumeroEtudiant == numeroEtudiantRechercher)
				{
					Console.WriteLine(etudiant.ToString());
				}
			}
		}
	}
}
