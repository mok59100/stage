using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Dtos
{
    public partial class AdhesionsDTOIn
    {
        public int IdAdhesion { get; set; }
        public DateTime? DateDebutAdhesion { get; set; }
        public DateTime? DateFinAdhesion { get; set; }

        public int? IdUtilisateur { get; set; }
    }
   
    public partial class AdhesionsDTOOut
    {
        public int IdAdhesion { get; set; }
        public DateTime? DateDebutAdhesion { get; set; }
        public DateTime? DateFinAdhesion { get; set; }
        public int IdUtilisateur { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
