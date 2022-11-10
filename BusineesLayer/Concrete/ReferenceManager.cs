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
    public class ReferenceManager : IReferenceService
    {
        IReferenceRepository _referenceRepository;

        public ReferenceManager(IReferenceRepository referenceRepository)
        {
            _referenceRepository = referenceRepository;
        }

        public void Add(Reference t)
        {
            _referenceRepository.Insert(t);
        }

        public void Delete(Reference t)
        {
            _referenceRepository.Delete(t);
        }

        public Reference GetById(int id)
        {
            return _referenceRepository.GetById(id);
        }

        public List<Reference> GetList()
        {
            return _referenceRepository.GetList();
        }

        public void Update(Reference t)
        {
            _referenceRepository.Update(t);
        }
    }
}
