using EASL.Data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Dtos
{
    public partial class MessagesDTOIn
    {

        public int IdMessage { get; set; }
        public string Dates { get; set; }
        public string Heure { get; set; }
        public string Auteur { get; set; }
        public string Message { get; set; }

    }

  
}
