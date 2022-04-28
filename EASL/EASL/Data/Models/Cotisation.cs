using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Cotisation
    {
        public int IdCotisation { get; set; }
        public string EtatCotisation { get; set; }
        public string MontantCotisation { get; set; }
        public string ModePaiement { get; set; }
        public DateTime? DateCotisation { get; set; }
        public int IdUtilisateur { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
    }
}
