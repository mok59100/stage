using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Dtos
{
    public partial class ActualitesDTOIn
    {
  
        public int IdActualite { get; set; }
        public string Titre { get; set; }
        public string Contenu { get; set; }
        public DateTime? DateAffichage { get; set; }
    }

    public partial class ActualitesDTOOut
    {
  
        public int IdActualite { get; set; }
        public string Titre { get; set; }
        public string Contenu { get; set; }
        public DateTime? DateAffichage { get; set; }
        public virtual Appartient Appartient { get; set; }
        public virtual Contient Contient { get; set; }
    }
}
