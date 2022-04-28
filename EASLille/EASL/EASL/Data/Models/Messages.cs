using System;
using System.Collections.Generic;

#nullable disable

namespace EASL.Data.Models
{
    public partial class Messages
    {
     

        public int IdMessage { get; set; }
        public string Dates { get; set; }
        public string Heure{ get; set; }
        public string Auteur { get; set; }
        public string Message { get; set; }

    }
}
