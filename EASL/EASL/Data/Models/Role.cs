using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Role
    {
        public Role()
        {
            Utilisateurs = new HashSet<Utilisateur>();
        }

        public int IdRole { get; set; }
        public string LibelleRole { get; set; }

        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
