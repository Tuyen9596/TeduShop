using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model;

namespace TeduShop.Data.Responsitory
{
    public interface IVisitorstatusticRepository
    {

    }
    class VisitorstatusticRepository : RepositoryBase<VisitorStatistic>, IVisitorstatusticRepository
    {
        public VisitorstatusticRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }

}
