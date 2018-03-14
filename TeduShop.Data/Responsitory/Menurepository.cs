using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model;

namespace TeduShop.Data.Responsitory
{
    public interface IMenuRepository : IRepository<Menu>
    {

    }
    class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
