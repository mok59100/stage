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
      class DonsProfiles :Profile
    {
    public DonsProfiles()
    {
         CreateMap<Don, DonsDTOIn>();
        CreateMap<DonsDTOIn, Don>();
            CreateMap<Don, DonsDTOOut>();
            CreateMap<DonsDTOOut, Don>();

        }
}
}