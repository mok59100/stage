using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Appartient
    {
        public int IdActualite { get; set; }
        public int IdVideo { get; set; }

        public virtual Actualite IdActualiteNavigation { get; set; }
        public virtual Video IdVideoNavigation { get; set; }
    }
}
