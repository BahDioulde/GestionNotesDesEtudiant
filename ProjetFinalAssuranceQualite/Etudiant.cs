using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	class Etudiant
	{
		public static void AfficherListeEtudiant(List<Etudiant> listeEtudiants)
		{
			if (listeEtudiants.Count < 1)
			{
				Console.WriteLine("Aucun etudiant disponible dans votre base de donnee\n");
			}
			foreach (Etudiant etud in listeEtudiants)
			{
				Console.WriteLine(etud.ToString());
			}
		}
	}
}
