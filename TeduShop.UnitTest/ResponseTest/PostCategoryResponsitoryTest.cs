using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Responsitory;

namespace TeduShop.UnitTest.ResponseTest
{
    [TestClass]
   public class PostCategoryResponsitoryTest
    {
        IDbFactory dbFactory;
        PostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
       [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);

        }
    }
}
