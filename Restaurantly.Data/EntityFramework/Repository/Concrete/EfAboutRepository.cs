using Microsoft.EntityFrameworkCore;
using Restaurantly.Data.EntityFramework.Contexts;
using Restaurantly.Data.EntityFramework.Repository.Abstract;
using Restaurantly.Entity.Entity;
using Restaurantly.Shared.Data.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Data.EntityFramework.Repository.Concrete
{
    public class EfAboutRepository : GenericRepository<About>, IAboutRepository
    {
        public EfAboutRepository(DbContext context) : base(context)
        {
        }
    }
}
