using AutoMapper;
using Restaurantly.Data.Abstract;
using Restaurantly.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.Abstract
{
    public interface IReservationService
    {
     

        ReservationDto Get(int aboutId);
        ReservationListDto GetAll();
        void Add(ReservationAddDto dto);
        void Update(ReservationUpdateDto dto);
        void Delete(int id);
    }
}
