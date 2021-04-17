using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	public class Cours
	{
		
      private static int codeIncrement;
      private int CodeCours { get; }
      public int NumeroCours { get; set; }
      public string TitreCours { get; set; }

      public Cours(int numeroCours, string titreCours)
      {
        this.CodeCours = ++codeIncrement;
        this.NumeroCours = numeroCours;
        this.TitreCours = titreCours;
      }

       public override string ToString()
      {
        return "\n\tCode du cours : "+this.CodeCours+"\n\tNumero du Cours : "
        +this.NumeroCours+"\n\tTitre du cours : "+this.TitreCours;
      }

      public static void RechercherCours(int numeroCoursRechercher)
      {
        foreach (Cours cours in Program.ListDesCours)
        {
          if (cours.NumeroCours == numeroCoursRechercher)
          {
            Console.WriteLine(cours.ToString());
          }
        }
      }

	}
}
