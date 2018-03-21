using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Responsitory
{
    public interface IVisitorstatusticRepository : IRepository<VisitorStatistic>
    {
    }

    internal class VisitorstatusticRepository : RepositoryBase<VisitorStatistic>, IVisitorstatusticRepository
    {
        public VisitorstatusticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}