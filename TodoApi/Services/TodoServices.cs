using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services
{
    public class TodoServices : ITodoServices
    {
        private List<Todo> _TodoRepo = new List<Todo>();
        public Todo Create(Todo item)
        {
            _TodoRepo.Add(item);
            return item;
        }

        public string Delete(Guid Id)
        {
            for (var index = _TodoRepo.Count - 1; index >= 0; index--)
            {
                if (_TodoRepo[index].Id == Id)
                {
                    _TodoRepo.RemoveAt(index);
                }
            }
            return $"Tarefa deletada";
        }

        public Todo Details(Guid Id)
        {
            return _TodoRepo.Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<Todo> Index()
        {
            return _TodoRepo;
        }

        public Todo Update(Guid id, Todo item)
        {
            for (var index = _TodoRepo.Count - 1; index >= 0; index--)
            {
                if (_TodoRepo[index].Id == id)
                {
                    _TodoRepo[index] = item;
                }
            }
            return item;
        }
    }
}
