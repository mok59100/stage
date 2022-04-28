using EASL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Services
{
    class CotisationsServices
    {
        private readonly MyDbContext _context;

        public CotisationsServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddCotisation(Cotisation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Cotisations.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteCotisation(Cotisation obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Cotisations.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Cotisation> GetAllCotisations()
        {
            return _context.Cotisations.Include("Utilisateur").ToList();
        }

        public Cotisation GetCotisationById(int id)
        {
            return _context.Cotisations.Include("Utilisateur").FirstOrDefault(obj => obj.IdCotisation == id);
        }

        public void UpdateCotisation(Cotisation obj)
        {
            _context.SaveChanges();
        }


    }
}
