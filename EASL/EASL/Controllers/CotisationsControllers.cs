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
    class CotisationsControllers :ControllerBase
    {
        private readonly CotisationsServices _service;
        private readonly IMapper _mapper;

        public CotisationsControllers(MyDbContext _context)
        {
            _service = new CotisationsServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CotisationsProfiles>();

            });
            _mapper = config.CreateMapper();
        }

        //GET api/Cotisations
        [HttpGet]
        public IEnumerable<CotisationsDTOIn> GetAllCotisations()
        {
            IEnumerable<Cotisation> listeCotisations = _service.GetAllCotisations();
            return _mapper.Map<IEnumerable<CotisationsDTOIn>>(listeCotisations);
        }

        //GET api/Cotisations/{i}
        [HttpGet("{id}", Name = "GetCotisationById")]
        public ActionResult<CotisationsDTOIn> GetCotisationById(int id)
        {
            Cotisation commandItem = _service.GetCotisationById(id);
            if (commandItem != null)
            {
                return _mapper.Map<CotisationsDTOIn>(commandItem);
            }
            return NotFound();
        }

        //POST api/NomController
        [HttpPost]
        public ActionResult<CotisationsDTOIn> CreateCotisation(CotisationsDTOIn objIn)
        {
            Cotisation obj = _mapper.Map<Cotisation>(objIn);
            _service.AddCotisation(obj);
            return CreatedAtRoute(nameof(GetCotisationById), new { Id = obj.IdCotisation }, obj);
        }

        //POST api/NomController/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCotisation(int id, CotisationsDTOIn obj)
        {
            Cotisation objFromRepo = _service.GetCotisationById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateCotisation(objFromRepo);
            return NoContent();
        }

       

        //DELETE api/NomController/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCotisation(int id)
        {
            Cotisation obj = _service.GetCotisationById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteCotisation(obj);
            return NoContent();
        }


    }
}
