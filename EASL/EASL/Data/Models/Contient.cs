using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Contient
    {
        public int IdActualite { get; set; }
        public int IdImage { get; set; }

        public virtual Actualite IdActualiteNavigation { get; set; }
        public virtual Image IdImageNavigation { get; set; }
    }
}
