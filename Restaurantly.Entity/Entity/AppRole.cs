﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Entity
{
    public  class AppRole : IdentityRole<int>
    {
        public string RoleType { get; set; }
    }
}
