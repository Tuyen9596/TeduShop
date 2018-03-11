using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;

namespace TeduShop.Data.Responsitory
{
    public interface IProductRepository
    {

    }

    public class ProductRepository:RepositoryBase<Model.Product>,IProductRepository
    {

        public ProductRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }

    }
}
