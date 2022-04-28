using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Services
{
    class ActualitesServices
    {
        private readonly MyDbContext _context;

        public ActualitesServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddActualite(Actualite obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Actualites.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteActualite(Actualite obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Actualites.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Actualite> GetAllActualites()
        {
            return _context.Actualites.ToList();
        }

        public Actualite GetActualiteById(int id)
        {
            return _context.Actualites.FirstOrDefault(obj => obj.IdActualite == id);
        }

        public void UpdateActualite(Actualite obj)
        {
            _context.SaveChanges();
        }


    }
}
