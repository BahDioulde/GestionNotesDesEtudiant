using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	class Note
	{
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
	}
}
