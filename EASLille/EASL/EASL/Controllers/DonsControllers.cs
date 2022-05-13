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
    class DonsControllers: ControllerBase
    {
        private readonly DonsServices _service;
        private readonly IMapper _mapper;

        public DonsControllers(MyDbContext _context)
        {
             _service = new DonsServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DonsProfiles>();

            });
            _mapper = config.CreateMapper();
        }

        //GET api/NomController
        [HttpGet]
        public IEnumerable<DonsDTOIn> GetAllDons()
        {
            IEnumerable<Don> listeDons = _service.GetAllDons();
            return _mapper.Map<IEnumerable<DonsDTOIn>>(listeDons);
        }

        //GET api/NomController/{i}
        [HttpGet("{id}", Name = "GetDonById")]
        public ActionResult<DonsDTOIn> GetDonById(int id)
        {
            Don commandItem = _service.GetDonById(id);
            if (commandItem != null)
            {
                return _mapper.Map<DonsDTOIn>(commandItem);
            }
            return NotFound();
        }

        //POST api/NomController
        [HttpPost]
        public ActionResult<DonsDTOIn> CreateDon(DonsDTOIn objIn)
        {
            Don obj = _mapper.Map<Don>(objIn);
            _service.AddDon(obj);
            return CreatedAtRoute(nameof(GetDonById), new { Id = obj.IdDon }, obj);
        }

        //POST api/NomController/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateDon(int id, DonsDTOIn obj)
        {
            Don objFromRepo = _service.GetDonById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateDon(objFromRepo);
            return NoContent();
        }

        //DELETE api/NomController/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteDon(int id)
        {
            Don obj = _service.GetDonById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteDon(obj);
            return NoContent();
        }




    }
}
