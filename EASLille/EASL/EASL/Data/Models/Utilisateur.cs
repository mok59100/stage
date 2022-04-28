using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Adhesions = new HashSet<Adhesion>();
            Cotisations = new HashSet<Cotisation>();
      
        }

        public int IdUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public string MotDePasse { get; set; }
        //public string Role { get; set; }
        public int? TelephoneUtilisateur { get; set; }
        public string SituationProfessionnelle { get; set; }
        public bool? Active { get; set; }
        public int IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<Adhesion> Adhesions { get; set; }
        public virtual ICollection<Cotisation> Cotisations { get; set; }
     
    }
}
