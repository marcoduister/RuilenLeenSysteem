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
        public string _Voornaam { get; set; }
        public string _Achternaam { get; set; }
        public string _Email { get; set; }
        protected string _password { get; }
    }
}
