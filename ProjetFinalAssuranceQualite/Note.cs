using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	class Note
	{
		public int NumeroEtudiant { get; set; }
		public int NumeroCours { get; set; }
		private double laNote;
		public double LaNote { get { return laNote; } set { laNote = (value >= 0 && value <= 100) ? value : 0; } }

		public Note(Etudiant etudiant, Cours cours, double laNote)
		{
			this.LaNote = laNote;
			this.NumeroEtudiant = etudiant.NumeroEtudiant;
			this.NumeroCours = cours.NumeroCours ;
		}

		public override string ToString()
		{
			return "\tNote : " + this.LaNote;
		}
    
    static double sommeDeNote = 0;
		static int compteurNote=0;
		public static void RechercheNoteEtudiant(int numeroEtudiantRechercher)
		{
			Etudiant.RechercheEtudiant(numeroEtudiantRechercher);
			foreach (Note note in Program.ListeNotesEtudiant)
			{
				if (note.NumeroEtudiant== numeroEtudiantRechercher)
				{
					Cours.RechercherCours(note.NumeroCours);
					Console.WriteLine(note.ToString());
					sommeDeNote+=note.LaNote;
					compteurNote++;
				}
			}
		}

		public static double CalculerMoyenne()
		{
			return sommeDeNote / compteurNote;
    }
  public static string AttribuerGrade()
		{
			string grade = "";
			if (CalculerMoyenne() <= 54) grade = "EC";
			else if (CalculerMoyenne() <= 59) grade = "DR";
			else if (CalculerMoyenne() <= 63) grade = "C-";
			else if (CalculerMoyenne() <= 66) grade = "C";
			else if (CalculerMoyenne() <= 69) grade = "C+";
			else if (CalculerMoyenne() <= 73) grade = "B-";
			else if (CalculerMoyenne() <= 76) grade = "B";
			else if (CalculerMoyenne() <= 79) grade = "B+";
			else if (CalculerMoyenne() <= 84) grade = "A-";
			else if (CalculerMoyenne() <= 89) grade = "A";
			else if (CalculerMoyenne() <= 100) grade ="A+";
			return grade;
     }

	}
}
