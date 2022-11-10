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
    public class ToDoListManager : IToDoListService
    {
        IToDoListRepository _toDoListRepository;

        public ToDoListManager(IToDoListRepository toDoListRepository)
        {
           _toDoListRepository = toDoListRepository;
        }

        public void Add(ToDoList t)
        {
            _toDoListRepository.Insert(t);
        }

        public void Delete(ToDoList t)
        {
            _toDoListRepository.Delete(t);
        }

        public ToDoList GetById(int id)
        {
            return _toDoListRepository.GetById(id);
        }

        public List<ToDoList> GetList()
        {
            return _toDoListRepository.GetList();
        }

        public void Update(ToDoList t)
        {
            _toDoListRepository.Update(t);
        }
    }
}
