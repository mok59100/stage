using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Dtos
{
    public partial class DonsDTOIn
    {
        public int IdDon { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string LibelleDon { get; set; }
        public decimal? MontantDon { get; set; }
    }

    public partial class DonsDTOOut
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string LibelleDon { get; set; }
        public decimal? MontantDon { get; set; }
    }
}
