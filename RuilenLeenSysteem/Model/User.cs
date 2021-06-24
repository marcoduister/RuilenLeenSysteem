using RuilenLeenSysteem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.Model
{
    class User
    {
        // Property / Attributes
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Roll Rol { get; set; }
    }
}
