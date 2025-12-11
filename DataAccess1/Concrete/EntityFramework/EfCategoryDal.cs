using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess1.Abstract;
using Entities.Concrete;

namespace DataAccess1.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Product, NorthwindContext> ,ICategoryDal
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>>? filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>>? filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                // Eğer filtre null ise (yani filtre verilmemişse) tüm kategorileri getir.
                // Eğer filtre verilmişse, filtreyi uygula öyle getir.
                return filter == null
                    ? context.Categories.ToList()
                    : context.Categories.Where(filter).ToList();
            }
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
