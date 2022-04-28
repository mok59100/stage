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
    class ActualitesControllers : ControllerBase
    {
        private readonly ActualitesServices _service;
        private readonly IMapper _mapper;

        public ActualitesControllers(MyDbContext _context)
        {
            _service = new ActualitesServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ActualitesProfiles>();

            });
            _mapper = config.CreateMapper();
        }

        //GET api/Actualites
        [HttpGet]
        public IEnumerable<ActualitesDTOIn> GetAllActualites()
        {
            IEnumerable<Actualite> listeActualites = _service.GetAllActualites();
            return _mapper.Map<IEnumerable<ActualitesDTOIn>>(listeActualites);
        }

        //GET api/Actualites/{i}
        [HttpGet("{id}", Name = "GetActualiteById")]
        public ActionResult<ActualitesDTOIn> GetActualiteById(int id)
        {
            Actualite commandItem = _service.GetActualiteById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<ActualitesDTOIn>(commandItem));
            }
            return NotFound();
        }

        //POST api/Actualites
        [HttpPost]
        public ActionResult<ActualitesDTOIn> CreateActualite(ActualitesDTOIn objIn)
        {
            Actualite obj = _mapper.Map<Actualite>(objIn);
            _service.AddActualite(obj);
            return CreatedAtRoute(nameof(GetActualiteById), new { Id = obj.IdActualite }, obj);
        }

        //POST api/Actualites/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateActualite(int id, ActualitesDTOIn obj)
        {
            Actualite objFromRepo = _service.GetActualiteById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateActualite(objFromRepo);
            return NoContent();
        }

       

        //DELETE api/Actualites/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteActualite(int id)
        {
            Actualite obj = _service.GetActualiteById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteActualite(obj);
            return NoContent();
        }


    }
}
