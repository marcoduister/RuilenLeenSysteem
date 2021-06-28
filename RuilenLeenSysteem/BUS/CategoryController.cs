using RuilenLeenSysteem.DAL;
using RuilenLeenSysteem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuilenLeenSysteem.BUS
{
    class CategoryController
    {
        private CategorieData _DbData;
        public CategoryController()
        {
            _DbData = new CategorieData();
        }

        internal List<Categorie> GetAllCategories()
        {
            return _DbData.GetAllCategories();
        }

    }
}
