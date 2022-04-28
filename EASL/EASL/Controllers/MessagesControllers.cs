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
    class MessagesControllers: ControllerBase
    {
        private readonly MessagesServices _service;
        private readonly IMapper _mapper;

        public MessagesControllers(MyDbContext _context)
        {
           _service = new MessagesServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MessagesProfiles>();

            });
            _mapper = config.CreateMapper();
        }

        //GET api/NomController
        [HttpGet]
        public IEnumerable<MessagesDTOIn> GetAllMessages()
        {
            IEnumerable<Messages> listeMessages = _service.GetAllMessages();
            return _mapper.Map<IEnumerable<MessagesDTOIn>>(listeMessages);
        }

        //GET api/NomController/{i}
        [HttpGet("{id}", Name = "GetMessageById")]
        public ActionResult<MessagesDTOIn> GetMessageById(int id)
        {
            Messages commandItem = _service.GetMessageById(id);
            if (commandItem != null)
            {
                return _mapper.Map<MessagesDTOIn>(commandItem);
            }
            return NotFound();
        }

        //POST api/NomController
        [HttpPost]
        public ActionResult<MessagesDTOIn> CreateMessage(MessagesDTOIn objIn)
        {
            Messages obj = _mapper.Map<Messages>(objIn);
            _service.AddMessage(obj);
            return CreatedAtRoute(nameof(GetMessageById), new { Id = obj.IdMessage }, obj);
        }

        //POST api/NomController/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateMessage(int id, MessagesDTOIn obj)
        {
            Messages objFromRepo = _service.GetMessageById(id);
            if (objFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateMessage(objFromRepo);
            return NoContent();
        }

        

        //DELETE api/NomController/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMessage(int id)
        {
            Messages obj = _service.GetMessageById(id);
            if (obj == null)
            {
                return NotFound();
            }
            _service.DeleteMessage(obj);
            return NoContent();
        }


    }
}
