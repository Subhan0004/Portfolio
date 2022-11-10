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
    public class ExperienceManager : IExperienceService
    {
        IExperienceRepository _experienceRepository;

        public ExperienceManager(IExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        public void Add(Experience t)
        {
            _experienceRepository.Insert(t);
        }

        public void Delete(Experience t)
        {
            _experienceRepository.Delete(t);
        }

        public Experience GetById(int id)
        {
            return _experienceRepository.GetById(id);
        }

        public List<Experience> GetList()
        {
            return _experienceRepository.GetList();
        }

        public void Update(Experience t)
        {
            _experienceRepository.Update(t);
        }
    }
}
