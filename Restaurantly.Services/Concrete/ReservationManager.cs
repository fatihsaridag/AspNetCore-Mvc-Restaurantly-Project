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
            var entity = _unitOfWork.Reservations.GetById(id);
            _unitOfWork.Reservations.Delete(entity);
            _unitOfWork.SaveChanges();
        }

        public ReservationDto Get(int reservationId)
        {
            var reservation = _unitOfWork.Reservations.GetById(reservationId);
            return new ReservationDto
            {
                Reservation = reservation
            };
        }

        public ReservationListDto GetAll()
        {
            var reservationsEntity = _unitOfWork.Reservations.GetList();
            return new ReservationListDto
            {
                Reservations = reservationsEntity
            };
        }

        public ReservationUpdateDto GetReservationUpdateDtoAsync(int id)
        {
            var reservation = _unitOfWork.Reservations.GetById(id);
            var reservationUpdatedDto = _mapper.Map<ReservationUpdateDto>(reservation);
            return reservationUpdatedDto;
        }

        public void Update(ReservationUpdateDto dto)
        {
            var reservation = _mapper.Map<Reservation>(dto);
            _unitOfWork.Reservations.Update(reservation);
            _unitOfWork.SaveChanges();
        }
    }
}
