using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Todo
    {
        public Todo()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Tarefa { get; set; }
    }
}
