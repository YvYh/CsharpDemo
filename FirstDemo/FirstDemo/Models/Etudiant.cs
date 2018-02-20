using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstDemo.Models
{
    public class Etudiant
    {
        public int NumInSee { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public Etudiant(int numInSee, String nom, String prenom, DateTime dateNaissance)
        {
            NumInSee = numInSee;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            return NumInSee.ToString() + " + " + Nom + " + " + Prenom + " + " + DateNaissance.ToString();
        }

    }
}