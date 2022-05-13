using AutoMapper;
using EASL.Data;
using EASL.Data.Dtos;
using EASL.Data.Models;
using EASL.Data.Profiles;
using EASL.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Controllers
{
    class UtilisateursControllers : ControllerBase
    {
        private readonly UtilisateursServices _service;
        private readonly IMapper _mapper;

        public UtilisateursControllers(MyDbContext _context)
        {
            _service = new UtilisateursServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<UtilisateursProfiles>();

            });
            _mapper = config.CreateMapper();
        }

        //GET api/NomController
        [HttpGet]
        public IEnumerable<UtilisateursDTOIn> GetAllUtilisateurs()
        {
            IEnumerable<Utilisateur> listeUtilisateurs = _service.GetAllUtilisateurs();
            return _mapper.Map<IEnumerable<UtilisateursDTOIn>>(listeUtilisateurs);
        }
        public IEnumerable<Utilisateur> GetAllUtilisateursModele()
        {
            IEnumerable<Utilisateur> listeUtilisateurs = _service.GetAllUtilisateurs();
            return listeUtilisateurs;
        }
        //GET api/NomController/{i}
        [HttpGet("{id}", Name = "GetUtilisateurById")]
        public ActionResult<UtilisateursDTOIn> GetUtilisateurById(int id)
        {
            Utilisateur commandItem = _service.GetUtilisateurById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<UtilisateursDTOIn>(commandItem));
            }
            return NotFound();
        }

        //POST api/Utilisateurs
        [HttpPost]
        public ActionResult<UtilisateursDTOIn> CreateUtilisateur(UtilisateursDTOIn objIn)
        {
            Utilisateur obj = _mapper.Map<Utilisateur>(objIn);
            _service.AddUtilisateur(obj);
            return CreatedAtRoute(nameof(GetUtilisateurById), new { Id = obj.IdUtilisateur }, obj);
        }

        //POST api/NomController/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUtilisateur(int id, UtilisateursDTOIn obj)
        {
            Utilisateur objFromRepo = _service.GetUtilisateurById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateUtilisateur(objFromRepo);
            return NoContent();
        }



        //DELETE api/NomController/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteUtilisateur(int id)
        {
            Utilisateur obj = _service.GetUtilisateurById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteUtilisateur(obj);
            return NoContent();
        }


    }
}