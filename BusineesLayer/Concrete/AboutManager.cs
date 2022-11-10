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
    public class AboutManager : IAboutService
    {
        IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }

        public void Add(About t)
        {
            _aboutRepository.Insert(t);
        }

        public void Delete(About t)
        {
            _aboutRepository.Delete(t);
        }

        public About GetById(int id)
        {
            return _aboutRepository.GetById(id);
        }

        public List<About> GetList()
        {
           return _aboutRepository.GetList();
        }

        public void Update(About t)
        {
            _aboutRepository.Update(t);
        }
    }
}
