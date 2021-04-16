using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	class Program
	{
		static void Main(string[] args)
		{
			public static void EnregistrerEtudiant()
		{
			
			string reponseChoisie = "O";
			int numeroEtudiant;
			do
			{
				Console.Clear();
                Console.WriteLine("\t***** Inscription des etudiants *****");
				Console.Write("\n\tNumero de l'etudiant : ");
				numeroEtudiant = VerifierLaSaisieEntier();
				if (numeroEtudiant < 1)
					continue;
				Console.Write("\tNom de l'etudiant : ");
				string nomEtudiant = Console.ReadLine();
				Console.Write("\tPrenom de l'etudiant : ");
				string prenomEtudiant = Console.ReadLine();

				etudiant = new Etudiant(numeroEtudiant, nomEtudiant, prenomEtudiant);
				ListEtudiants.Add(etudiant);
				do
				{
					Console.Write("\tvoulez vous continuer L'ENREGISTREMENT O/N ? : ");
					reponseChoisie = Console.ReadLine();
				} while (reponseChoisie.ToUpper().Substring(0) != "N" && reponseChoisie.ToUpper().Substring(0) != "O");

			} while (reponseChoisie.ToUpper().Substring(0) == "O");
		}
		}
	}
}
