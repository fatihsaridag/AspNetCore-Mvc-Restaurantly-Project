using Restaurantly.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Entity.Dtos
{
    public class ReservationListDto
    {
        public List<Reservation> Reservations { get; set; }
    }
}
