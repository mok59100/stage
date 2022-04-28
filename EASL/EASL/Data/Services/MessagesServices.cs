using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Services
{
    class MessagesServices
    {
        private readonly MyDbContext _context;

        public MessagesServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddMessage(Messages obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Messages.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteMessage(Messages obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Messages.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Messages> GetAllMessages()
        {
            return _context.Messages.ToList();
        }

        public Messages GetMessageById(int id)
        {
            return _context.Messages.FirstOrDefault(obj => obj.IdMessage == id);
        }

        public void UpdateMessage(Messages obj)
        {
            _context.SaveChanges();
        }


    }
}
