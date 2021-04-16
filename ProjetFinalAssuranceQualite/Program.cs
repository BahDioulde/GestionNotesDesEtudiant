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
		static Etudiant etudiant;
		public static List<Etudiant> ListEtudiants = new List<Etudiant>();
		public static List<Note> ListeNotesEtudiant = new List<Note>();
		public static List<Cours> ListDesCours = new List<Cours>();
		static int choixDuMenu;
		static Cours cours;

		public static int VerifierLaSaisieEntier()
		{
			do
			{
				int ValeurDeSortie = 0;
				string valSaisi = Console.ReadLine();
				if (int.TryParse(valSaisi, out ValeurDeSortie))
				{
					return ValeurDeSortie;
				}
				else
				{
					Console.ReadKey();
					Console.Write("\tVous devez saisir un nombre : ");
					Thread.Sleep(2000);
					return 0;
				}
			} while (VerifierLaSaisieEntier() == 0);

		}
		}
	}
}
