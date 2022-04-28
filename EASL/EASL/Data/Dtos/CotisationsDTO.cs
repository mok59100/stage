using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Dtos
{
    public partial class CotisationsDTOIn
    {
        public int IdCotisation { get; set; }
        public string EtatCotisation { get; set; }
        public string MontantCotisation { get; set; }
        public string ModePaiement { get; set; }
        public DateTime? DateCotisation { get; set; }
        public int IdUtilisateur { get; set; }

    }
    public partial class CotisationsDTOOut
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