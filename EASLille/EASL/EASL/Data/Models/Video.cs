using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Video
    {
        public Video()
        {
            Appartients = new HashSet<Appartient>();
        }

        public int IdVideo { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Appartient> Appartients { get; set; }
    }
}
