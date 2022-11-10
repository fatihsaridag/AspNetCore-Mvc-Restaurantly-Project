using AutoMapper;
using Restaurantly.Data.Abstract;
using Restaurantly.Entity.Dtos;
using Restaurantly.Entity.Entity;
using Restaurantly.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.Concrete
{
    public class ReservationManager : IReservationService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ReservationManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public void Add(ReservationAddDto reservationAddDto)
        {
            var reservation = _mapper.Map<Reservation>(reservationAddDto);
            _unitOfWork.Reservations.Add(reservation);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ReservationDto Get(int aboutId)
        {
            throw new NotImplementedException();
        }

        public ReservationListDto GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ReservationUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
