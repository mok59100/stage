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
    class AdhesionsControllers : ControllerBase
    {
        private readonly AdhesionsServices _service;
        private readonly IMapper _mapper;

        public AdhesionsControllers(MyDbContext _context)
        {
            _service = new AdhesionsServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AdhesionsProfiles>();

            });
            _mapper = config.CreateMapper();
        }

        //GET api/Adhesions
        [HttpGet]
        public IEnumerable<AdhesionsDTOOut> GetAllAdhesions()
        {
            IEnumerable<Adhesion> listeAdhesions = _service.GetAllAdhesions();
            return _mapper.Map<IEnumerable<AdhesionsDTOOut>>(listeAdhesions);
        }

        //GET api/Adhesions/{i}
        [HttpGet("{id}", Name = "GetAdhesionById")]
        public ActionResult<AdhesionsDTOOut> GetAdhesionById(int id)
        {
            Adhesion commandItem = _service.GetAdhesionById(id);
            if (commandItem != null)
            {
                return Ok(_mapper.Map<AdhesionsDTOOut>(commandItem));
            }
            return NotFound();
        }

        //POST api/Adhesions
        [HttpPost]
        public ActionResult<AdhesionsDTOIn> CreateAdhesion(AdhesionsDTOIn objIn)
        {
            Adhesion obj = _mapper.Map<Adhesion>(objIn);
            _service.AddAdhesion(obj);
            return CreatedAtRoute(nameof(GetAdhesionById), new { Id = obj.IdAdhesion }, obj);
        }

        //POST api/Adhesions/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateAdhesion(int id, AdhesionsDTOIn obj)
        {
            Adhesion objFromRepo = _service.GetAdhesionById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateAdhesion(objFromRepo);
            return NoContent();
        }



        //DELETE api/Adhesions/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteAdhesion (int id)
        {
            Adhesion obj = _service.GetAdhesionById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteAdhesion (obj);
            return NoContent();
        }


    }
}
