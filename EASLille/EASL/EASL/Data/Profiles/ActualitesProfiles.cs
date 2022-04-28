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
      class ActualitesProfiles :Profile
    {
       public ActualitesProfiles()
        {
        CreateMap<Actualite, ActualitesDTOIn>();
        CreateMap<ActualitesDTOIn, Actualite>();
        CreateMap<Actualite, ActualitesDTOOut>();
        CreateMap<ActualitesDTOOut, Actualite>();
    
       }
    }
}