using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model;

namespace TeduShop.Data.Responsitory
{
    public interface IPostRepository:IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string Tag, int pageIndex, int pageSize, out int totalRow);
    }
    class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory):base(dbFactory){

        }

        public IEnumerable<Post> GetAllByTag(string Tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == Tag && p.Status==true
                        orderby p.CreateDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}
