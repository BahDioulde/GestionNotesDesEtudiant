using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	class Etudiant
	{  
		public int NumeroEtudiant { get; set; }
		public string Nom {get; set; }
		public string Prenom { get; set; }

		public Etudiant(int numeroEtudiant, string nom, string prenom)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			this.NumeroEtudiant = numeroEtudiant;
		}
		public override string ToString()
		{
			return "\n\tNumero Etudiant "+this.NumeroEtudiant+"\n\tNom : "+this.Nom+"\n\tPrenom : "+this.Prenom;
		}
	}
}
