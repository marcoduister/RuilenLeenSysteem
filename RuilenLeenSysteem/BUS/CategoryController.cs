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

        internal List<Category> GetAllCategories()
        {
            return _DbData.GetAllCategories();
        }

        internal bool DeleteCategory(int Category_id)
        {
            bool Deleted = false;
            if (_DbData.ExistCategoryById(Category_id))
            {
                _DbData.DeleteCategory(Category_id);
                Deleted = true;
            }

            return Deleted;
        }

        internal bool AddCategory(string Name, string Description)
        {
            bool created = false;
                Category AddCategory = new Category()
                {
                    Name = Name,
                    Description = Description,
                };
                
                created = _DbData.AddCategory(AddCategory);

            return created;
        }

        internal bool EditCategory(int category_id, string Name, string Description)
        {
            bool created = false;
            if (_DbData.ExistCategoryById(category_id))
            {
                Category EditCustomer = new Category()
                {
                    Id = category_id,
                    Name = Name,
                    Description = Description,
                };
                _DbData.EditCategory(EditCustomer);
                created = true;
            }

            return created;
        }

        internal Category GetCategoryById(int Category_id)
        {
            Category categorie = new Category();
            if (_DbData.ExistCategoryById(Category_id))
            {
                categorie =_DbData.GetCategorieById(Category_id);
            }

            return categorie;
        }
    }
}
