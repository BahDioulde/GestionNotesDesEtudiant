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
			this.NumeroCours = cours.NumeroCours;
		}

		public override string ToString()
		{
			return "\tNote : " + this.LaNote;
		}
	}
}
