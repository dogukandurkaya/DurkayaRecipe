using DurkayaRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurkayaRecipe.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Create(Category entity, int[] categoryIds);
        Category GetByIdWithCategories(int id);
        void Update(Category entity, int[] categoryIds);



    }
}
