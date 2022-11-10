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
    public class MediaManager : IMediaService
    {
        IMediaRepository _mediaRepository;

        public MediaManager(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        public void Add(Media t)
        {
            _mediaRepository.Insert(t);
        }

        public void Delete(Media t)
        {
            _mediaRepository.Delete(t);
        }

        public Media GetById(int id)
        {
            return _mediaRepository.GetById(id);
        }

        public List<Media> GetList()
        {
            return _mediaRepository.GetList();
        }

        public void Update(Media t)
        {
            _mediaRepository.Update(t);
        }
    }
}
