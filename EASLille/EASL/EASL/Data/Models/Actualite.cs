using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Actualite
    {
        public int IdActualite { get; set; }
        public string Titre { get; set; }
        public string Contenu { get; set; }
        public DateTime? DateAffichage { get; set; }

        public virtual Appartient Appartient { get; set; }
        public virtual Contient Contient { get; set; }
    }
}
