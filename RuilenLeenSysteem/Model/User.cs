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
        public int _Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string _Email { get; set; }
        protected string _password { get; }
    }
}
