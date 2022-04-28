using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Services
{
    class DonsServices
    {
        private readonly MyDbContext _context;

        public DonsServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddDon(Don obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Dons.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteDon(Don obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Dons.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Don> GetAllDons()
        {
            return _context.Dons.ToList();
        }

        public Don GetDonById(int id)
        {
            return _context.Dons.FirstOrDefault(obj => obj.IdDon == id);
        }

        public void UpdateDon(Don obj)
        {
            _context.SaveChanges();
        }


    }
}
