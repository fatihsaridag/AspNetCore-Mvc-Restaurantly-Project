using Restaurantly.Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurantly.Services.Abstract
{
    public interface IContactService
    {
        ContactDto Get(int aboutId);
        ContactUpdateDto GetUpdateContact(int contactid);
        ContactListDto GetAll();
        void Add(ContactAddDto dto);
        void Update(ContactUpdateDto dto);
        void Delete(int id);
    }
}
