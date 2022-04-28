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
      class UtilisateursProfiles :Profile
    {
    public UtilisateursProfiles()
    {
        
        CreateMap<Utilisateur, UtilisateursDTOIn>();
        CreateMap<UtilisateursDTOIn, Utilisateur>();
        CreateMap<Utilisateur, UtilisateursDTOOut>();
        CreateMap<UtilisateursDTOOut, Utilisateur>();
        }
}
}