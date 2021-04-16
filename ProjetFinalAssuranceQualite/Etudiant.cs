using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
  public class Etudiant
	
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
    
    public static void AfficherListeEtudiant(List<Etudiant> listeEtudiants)
     {
       if (listeEtudiants.Count < 1)
       {
          Console.WriteLine("Aucun etudiant disponible dans votre base de donnee\n");
        }
       foreach (Etudiant etud in listeEtudiants)
        {
          Console.WriteLine(etud.ToString());
        }
    }
	}
}
