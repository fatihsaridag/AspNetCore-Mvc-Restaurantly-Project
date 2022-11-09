﻿using Restaurantly.Entity.Entity;
using Restaurantly.Shared.Data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Data.EntityFramework.Repository.Abstract
{
    public interface IChefRepository : IGenericRepository<Chef>
    {
    }
}
