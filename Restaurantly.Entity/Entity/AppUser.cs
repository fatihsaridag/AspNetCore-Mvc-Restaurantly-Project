using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Entity
{
    public class AppUser : IdentityUser<int>
    {
        public string Picture { get; set; }
        public string Job { get; set; }
    }
}
