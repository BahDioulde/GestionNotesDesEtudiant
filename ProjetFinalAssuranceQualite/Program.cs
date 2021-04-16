using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	class Program
	{
		
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
	  
	}
}
