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
    public class SkillManager : ISkillService
    {
        ISkillRepository _skillRepository;

        public SkillManager(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public void Add(Skill t)
        {
            _skillRepository.Insert(t);
        }

        public void Delete(Skill t)
        {
            _skillRepository.Delete(t);
        }

        public Skill GetById(int id)
        {
            return _skillRepository.GetById(id);
        }

        public List<Skill> GetList()
        {
            return _skillRepository.GetList();
        }

        public void Update(Skill t)
        {
            _skillRepository.Update(t);
        }
    }
}
