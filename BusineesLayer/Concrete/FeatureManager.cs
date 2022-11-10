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
    public class FeatureManager : IFeatureService
    {
        IFeatureRepository _featureRepository;

        public FeatureManager(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public void Add(Feature t)
        {
            _featureRepository.Insert(t);
        }

        public void Delete(Feature t)
        {
            _featureRepository.Delete(t);
        }

        public Feature GetById(int id)
        {
            return _featureRepository.GetById(id);
        }

        public List<Feature> GetList()
        {
            return _featureRepository.GetList();
        }

        public void Update(Feature t)
        {
            _featureRepository.Update(t);
        }
    }
}
