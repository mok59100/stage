using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Dtos
{
    public partial class RolesDTOIn
    {



        public int IdRole { get; set; }
        public string LibelleRole { get; set; }
    }
    public partial class RolesDTOOut
    {
     
        public RolesDTOOut()
        {
            Utilisateurs = new HashSet<Utilisateur>();
        }

        public int IdRole { get; set; }
        public string LibelleRole { get; set; }

            public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
