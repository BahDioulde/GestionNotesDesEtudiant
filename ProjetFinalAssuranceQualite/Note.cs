using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalAssuranceQualite
{
	class Note
	{
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
