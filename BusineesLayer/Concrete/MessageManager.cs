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
    public class MessageManager : IMessageService
    {
        IMessageRepository _messageRepository;

        public MessageManager(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public void Add(Message t)
        {
            _messageRepository.Insert(t);
        }

        public void Delete(Message t)
        {
            _messageRepository.Delete(t);
        }

        public Message GetById(int id)
        {
            return _messageRepository.GetById(id);
        }

        public List<Message> GetList()
        {
            return _messageRepository.GetList();
        }

        public void Update(Message t)
        {
            _messageRepository.Update(t);
        }
    }
}
