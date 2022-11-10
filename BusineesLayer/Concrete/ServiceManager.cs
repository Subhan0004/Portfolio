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
    public class ServiceManager : IServiceService
    {
        IServiceRepository _serviceManager;

        public ServiceManager(IServiceRepository serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public void Add(Service t)
        {
            _serviceManager.Insert(t);
        }

        public void Delete(Service t)
        {
            _serviceManager.Delete(t);
        }

        public Service GetById(int id)
        {
            return _serviceManager.GetById(id);
        }

        public List<Service> GetList()
        {
            return _serviceManager.GetList();
        }

        public void Update(Service t)
        {
            _serviceManager.Update(t);
        }
    }
}
