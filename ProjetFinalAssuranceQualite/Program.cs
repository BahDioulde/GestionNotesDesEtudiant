using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
  public class Program
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

    public static Etudiant VerificationNumeroEtudiant(int numeroEtudiant)
		{

			foreach (Etudiant etudiant in ListEtudiants)
			{
				if (etudiant.NumeroEtudiant == numeroEtudiant)
				{
					return etudiant;
				}
			}
			return null;  
    }
      
		public static Cours VerificationNumeroCours(int numeroCours)
		{
			foreach (Cours cours in ListDesCours)
			{
				if (cours.NumeroCours == numeroCours)
				{
					return cours;
				}
			}
			return null;
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

  public static void EnregistrerCours()
		{
			string reponseChoisie = "O";
			do
			{
				Console.Clear();
                Console.WriteLine("\t***** Enregistrement des cours dispenses en classe *****\n");
				Console.Write("\tNumero du Cours : ");
				int numcours = VerifierLaSaisieEntier();
				if (numcours == 0)
				{
					Thread.Sleep(2000);
					continue;
				}
				Console.Write("\tTitre du Cours : ");
				string nomTitre = Console.ReadLine();
				cours = new Cours(numcours, nomTitre);
				ListDesCours.Add(cours);

				do
				{
					Console.Write("\tVoulez-vous continuer l'enregistrement O/N ? : ");
					reponseChoisie = Console.ReadLine();
				} while (reponseChoisie.ToUpper().Substring(0) != "N" && reponseChoisie.ToUpper().Substring(0) != "O");

			} while (reponseChoisie.ToUpper().Substring(0) == "O");
		}

	}
}
