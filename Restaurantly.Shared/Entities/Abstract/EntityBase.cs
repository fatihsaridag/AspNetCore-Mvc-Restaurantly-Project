using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Shared.Entities.Abstract
{
    public abstract class EntityBase
    {
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
