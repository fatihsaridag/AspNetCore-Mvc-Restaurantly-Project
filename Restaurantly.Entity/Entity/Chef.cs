using Restaurantly.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Entity
{
    public class Chef : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Job { get; set; }
    }
}
