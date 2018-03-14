﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model;

namespace TeduShop.Data.Responsitory
{
    public interface ISlideRepository : IRepository<Slide>
    {

    }
    class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }

}
