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
			public static void Menu()
			{
				Console.Clear();
				Console.WriteLine("1. Gestion des etudiants ");
				Console.WriteLine("2. Enregistrement Cours");
				Console.WriteLine("3. Enregistrement Notes");
				Console.WriteLine("4. Afficher Etudiants ");
				Console.WriteLine("5. Rechercher un releve");
			do
			{
				choixDuMenu = VerifierLaSaisieEntier();
			} while (choixDuMenu < 1);

			}
			
			public static void AfficherReleveDeNote()
			{
				Console.Clear();
				Console.Write("\tENTREZ UN NUMERO D'ETUDIANT A RECHERCHER :");
				int numeroRechercher = VerifierLaSaisieEntier();
				Console.WriteLine("*****Le Releve de Note*****");
				Note.RechercheNoteEtudiant(numeroRechercher);
				Console.WriteLine("\n\tMoyenne : " + Note.CalculerMoyenne());
				Console.WriteLine("\tGrade : " + Note.AttribuerGrade());

			}

			
		}
	}
}
