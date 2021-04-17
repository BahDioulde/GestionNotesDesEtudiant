using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
public class Program
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
			
			public static void EnregistrementDesNotes()
		{
			Console.Clear();
			string reponseChoisie = "N";
			int numeroEtudiant, numeroCours;
			if (ListEtudiants.Count < 1)
			{
				Console.WriteLine("\n\tVous n'avez aucun etudiant inscrit!!! pensez a enregistrer vos etudiant");
				Thread.Sleep(3200);
				EnregistrerEtudiant();
			}

			if (ListDesCours.Count < 1)
			{
				Console.WriteLine("\n\tVous n'avez aucun cours inscrit!!! pensez a enregistrer les cours dispensés dans votre école ");
				Thread.Sleep(3200);
				EnregistrerCours();
			}
			Console.Clear();
			Console.WriteLine("\n\tEnregistrement des Notes des Etudiants");
			do
			{
				do
				{
					Console.Write("\n\tNumero Etudiant : ");
					numeroEtudiant = VerifierLaSaisieEntier();
					if (numeroEtudiant < 1)
						continue;
					if (VerificationNumeroEtudiant(numeroEtudiant) == null)
						Console.WriteLine("\tetudiant introuvable\n");
				} while (VerificationNumeroEtudiant(numeroEtudiant) == null);

				do
				{
					Console.Write("\n\tNumero Cours : ");
					numeroCours = VerifierLaSaisieEntier();
					if (numeroCours < 1)
						continue;
					if (VerificationNumeroCours(numeroCours) == null)
						Console.Write("\tCours introuvable\n");
				} while (VerificationNumeroCours(numeroCours) == null);

				Console.Write("\n\tSaire la note : ");

				bool verifier;
				double laNote = 0.0;

				do
				{
					verifier = true;
					try
					{
						laNote = double.Parse(Console.ReadLine());
					}
					catch (FormatException)
					{
						Console.Write("\tErreur! Vous devez saisir un nombre : ");
						verifier = false;
					}
				} while (!verifier);


				Note note = new Note(VerificationNumeroEtudiant(numeroEtudiant), VerificationNumeroCours(numeroCours), laNote);
				ListeNotesEtudiant.Add(note);
				do
				{
					Console.Write("\n\tVoulez-vous enregistrer une autre note O/N ? ");
					reponseChoisie = Console.ReadLine();
				} while (reponseChoisie.ToUpper().Substring(0) != "N" && reponseChoisie.ToUpper().Substring(0) != "O");

			} while (reponseChoisie.ToUpper().Substring(0) == "O");
		}

		}
	}
}
