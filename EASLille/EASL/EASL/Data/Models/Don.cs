using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Don
    {
        public int IdDon { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string LibelleDon { get; set; }
        public decimal? MontantDon { get; set; }
    }
}
