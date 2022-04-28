using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Image
    {
        public Image()
        {
            Contients = new HashSet<Contient>();
        }

        public int IdImage { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Contient> Contients { get; set; }
    }
}
