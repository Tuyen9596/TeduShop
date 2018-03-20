using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model;
namespace TeduShop.Data.Responsitory
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {

    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>,IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory):base(dbFactory){

        }

    }
}
