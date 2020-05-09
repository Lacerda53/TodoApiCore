using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Models;

namespace TodoApi.Services
{
    public interface ITodoServices
    {
        public List<Todo> Index();
        public Todo Details(Guid id);
        public Todo Create(Todo item);
        public Todo Update(Guid id, Todo item);
        public string Delete(Guid Id);
    }
}
