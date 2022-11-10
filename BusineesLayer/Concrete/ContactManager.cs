using BusineesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusineesLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void Add(Contact t)
        {
            _contactRepository.Insert(t);
        }

        public void Delete(Contact t)
        {
            _contactRepository.Delete(t);
        }

        public Contact GetById(int id)
        {
            return _contactRepository.GetById(id);
        }

        public List<Contact> GetList()
        {
            return _contactRepository.GetList();
        }

        public void Update(Contact t)
        {
            _contactRepository.Update(t);
        }
    }
}
