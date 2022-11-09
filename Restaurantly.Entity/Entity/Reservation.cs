using Restaurantly.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Entity
{
    public class Reservation : EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public string Message { get; set; }
    }
}
