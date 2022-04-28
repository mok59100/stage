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
    class RolesControllers:ControllerBase
    {
        private readonly RolesServices _service;
        private readonly IMapper _mapper;

        public RolesControllers(MyDbContext _context)
        {
           _service = new RolesServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<RolesProfiles>();

            });
            _mapper = config.CreateMapper();
        }

        //GET api/NomController
        [HttpGet]
        public IEnumerable<RolesDTOIn> GetAllRoles()
        {
            IEnumerable<Role> listeRoles = _service.GetAllRoles();
            return _mapper.Map<IEnumerable<RolesDTOIn>>(listeRoles);
        }

        //GET api/NomController/{i}
        [HttpGet("{id}", Name = "GetRoleById")]
        public ActionResult<RolesDTOIn> GetRoleById(int id)
        {
            Role commandItem = _service.GetRoleById(id);
            if (commandItem != null)
            {
                return _mapper.Map<RolesDTOIn>(commandItem);
            }
            return NotFound();
        }

        //POST api/NomController
        [HttpPost]
        public ActionResult<RolesDTOIn> CreateRole(RolesDTOIn objIn)
        {
            Role obj = _mapper.Map<Role>(objIn);
            _service.AddRole(obj);
            return CreatedAtRoute(nameof(GetRoleById), new { Id = obj.IdRole }, obj);
        }

        //POST api/NomController/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateRole(int id, RolesDTOIn obj)
        {
            Role objFromRepo = _service.GetRoleById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateRole(objFromRepo);
            return NoContent();
        }

        

        //DELETE api/NomController/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteRole(int id)
        {
            Role obj = _service.GetRoleById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteRole(obj);
            return NoContent();
        }


    }
}
