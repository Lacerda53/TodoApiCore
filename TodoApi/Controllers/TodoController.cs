using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using TodoApi.Services;

namespace TodoApi.Controllers
{
    [Route("")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoServices _service;
        public TodoController(ITodoServices service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
           return _service.Index();
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> Get(Guid id)
        {
            return _service.Details(id);
        }

        [HttpPost]
        public ActionResult<Todo> Post([FromBody] Todo item)
        {
            _service.Create(item);
            return item;
        }

        [HttpPut("{id}")]
        public ActionResult<Todo> Put(Guid id, [FromBody] Todo item)
        {
            _service.Update(id, item);
            return item;
        }

        [HttpPatch("{id}")]
        public ActionResult<Todo> Patch(Guid id, [FromBody] Todo item)
        {
            _service.Update(id, item);
            return item;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.Delete(id);
        }
    }
}
