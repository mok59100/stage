using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Adhesion
    {
        public int IdAdhesion { get; set; }
        public DateTime? DateDebutAdhesion { get; set; }
        public DateTime? DateFinAdhesion { get; set; }
        public int IdUtilisateur { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
    }
}
