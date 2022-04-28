using EASL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Services
{
    class AdhesionsServices
    {
        private readonly MyDbContext _context;

        public AdhesionsServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddAdhesion(Adhesion obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Adhesions.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteAdhesion(Adhesion obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Adhesions.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Adhesion> GetAllAdhesions()
        {
            return _context.Adhesions.Include("Utilisateur").ToList();
        }

        public Adhesion GetAdhesionById(int id)
        {
            return _context.Adhesions.Include("Utilisateur").FirstOrDefault(obj => obj.IdAdhesion == id);
        }

        public void UpdateAdhesion(Adhesion obj)
        {
            _context.SaveChanges();
        }


    }
}
