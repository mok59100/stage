using EASL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Services
{
    class UtilisateursServices
    {
        private readonly MyDbContext _context;

        public UtilisateursServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddUtilisateur(Utilisateur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Utilisateurs.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteUtilisateur(Utilisateur obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Utilisateurs.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Utilisateur> GetAllUtilisateurs()
        {
            return _context.Utilisateurs.Include("IdRoleNavigation").ToList();
        }

        public Utilisateur GetUtilisateurById(int id)
        {
            return _context.Utilisateurs.Include("IdRoleNavigation").FirstOrDefault(obj => obj.IdUtilisateur == id);
        }

        public void UpdateUtilisateur(Utilisateur obj)
        {
            _context.SaveChanges();
        }


    }
}
