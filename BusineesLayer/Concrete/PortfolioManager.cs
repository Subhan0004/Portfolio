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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioRepository _portfolioRepository;

        public PortfolioManager(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }

        public void Add(Portfolio t)
        {
            _portfolioRepository.Insert(t);
        }

        public void Delete(Portfolio t)
        {
            _portfolioRepository.Delete(t);
        }

        public Portfolio GetById(int id)
        {
            return _portfolioRepository.GetById(id);
        }

        public List<Portfolio> GetList()
        {
            return _portfolioRepository.GetList();
        }

        public void Update(Portfolio t)
        {
            _portfolioRepository.Update(t);
        }
    }
}
