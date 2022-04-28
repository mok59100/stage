using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Dtos
{
    public partial class UtilisateursDTOIn
    {
        public int IdUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public string MotDePasse { get; set; }

    }

   

    public partial class UtilisateursDTOOut
    {
        public int IdUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AdresseMail { get; set; }
        public string MotDePasse { get; set; }
        public int? TelephoneUtilisateur { get; set; }
        public string SituationProfessionnelle { get; set; }
        public bool? Active { get; set; }
        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<Adhesion> Adhesions { get; set; }
        public virtual ICollection<Cotisation> Cotisations { get; set; }
      
    }

}
