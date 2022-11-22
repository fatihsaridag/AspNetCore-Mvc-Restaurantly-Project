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
    public class ContactManager : IContactService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public void Add(ContactAddDto dto)
        {
           var contactEntity =  _mapper.Map<Contact>(dto);
            _unitOfWork.Contacts.Add(contactEntity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ContactDto Get(int aboutId)
        {
            throw new NotImplementedException();
        }

        public ContactListDto GetAll()
        {
            var contacts = _unitOfWork.Contacts.GetList();
            return new ContactListDto
            {
                Contacts = contacts
            };
        }

        public ContactUpdateDto GetUpdateContact(int contactid)
        {
            var contact = _unitOfWork.Contacts.GetById(contactid);
            var contactUpdateDto =  _mapper.Map<ContactUpdateDto>(contact);
            return contactUpdateDto;
        }

        public void Update(ContactUpdateDto dto)
        {
           var contactDto  =  _mapper.Map<Contact>(dto);
          _unitOfWork.Contacts.Update(contactDto);
          _unitOfWork.SaveChanges();
        }
    }
}
