using AutoMapper;
using EASL.Data.Dtos;
using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Profiles
{
      class MessagesProfiles :Profile
    {
        public MessagesProfiles()
    {
        CreateMap<Messages, MessagesDTOIn>();
        CreateMap<MessagesDTOIn, Messages>();
     
    }
}
    }
