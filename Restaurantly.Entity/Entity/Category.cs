using Restaurantly.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Entity
{
    public class Category : EntityBase
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public IList<Menu> Menus { get; set; }
    }
}
