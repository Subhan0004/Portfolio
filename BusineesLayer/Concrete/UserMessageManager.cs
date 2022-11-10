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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageRepository _userMessageRepository;

        public UserMessageManager(IUserMessageRepository userMessageRepository)
        {
            _userMessageRepository = userMessageRepository;
        }

        public void Add(UserMessage t)
        {
            _userMessageRepository.Insert(t);
        }

        public void Delete(UserMessage t)
        {
            _userMessageRepository.Delete(t);
        }

        public UserMessage GetById(int id)
        {
            return _userMessageRepository.GetById(id);
        }

        public List<UserMessage> GetList()
        {
            return _userMessageRepository.GetList();
        }

        public List<UserMessage> ListByUserService()
        {
            return _userMessageRepository.ListByUser();
        }

        public void Update(UserMessage t)
        {
            _userMessageRepository.Update(t);
        }
    }
}
