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
			static void Main(string[] args)
		{
			string reponse;
			do
			{
				Menu();
				switch (choixDuMenu)
				{
					case 1:
						EnregistrerEtudiant();
						break;
					case 2:
						EnregistrerCours();
						break;
					case 3:
						EnregistrementDesNotes();
						break;
					case 4:
						Etudiant.AfficherListeEtudiant(ListEtudiants);
						break;
					case 5:
						AfficherReleveDeNote();
						break;
					default:
						break;
				}
				while (choixDuMenu < 1 || choixDuMenu > 5)
				{
					Console.Write("\tERREUR DE CHOIX! Veuillez entrer un chiffre compris entre 1 à 5 : ");
					choixDuMenu = VerifierLaSaisieEntier();
				}

				do
				{
					Console.Write("\tVoulez-vous une autre fonctionnalite O/N ? : ");
					reponse = Console.ReadLine();
				} while (reponse.ToUpper().Substring(0) != "N" && reponse.ToUpper().Substring(0) != "O");

			} while (reponse.ToUpper().Substring(0) == "O");
		}
	}
}
