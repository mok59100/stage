using EASL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASL.Data.Services
{
    class RolesServices
    {
        private readonly MyDbContext _context;

        public RolesServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddRole(Role obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Roles.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteRole(Role obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Roles.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }

        public Role GetRoleById(int id)
        {
            return _context.Roles.FirstOrDefault(obj => obj.IdRole == id);
        }

        public void UpdateRole(Role obj)
        {
            _context.SaveChanges();
        }


    }
}
