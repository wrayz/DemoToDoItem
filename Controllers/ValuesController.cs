using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<TodoItemDTO> Get()
        {
            return new TodoItemDTO 
            {
                Id = 1,
                Name = "Test",
                IsComplete = true
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<TodoItemDTO> Get(int id)
        {
            return new TodoItemDTO
            {
                Id = 99,
                Name = "Test Parameter",
                IsComplete = true
            };
        }

        // POST api/values
        [HttpPost]
        public ActionResult<TodoItemDTO> Post(TodoItemDTO item)
        {
            return new TodoItemDTO 
            {
                Id = 99,
                Name = item.Name,
                IsComplete = true
            };
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<TodoItemDTO> Put(int id, TodoItemDTO item)
        {
            return item;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<TodoItemDTO> Delete(int id)
        {
            return new TodoItemDTO 
            {
                Id = id,
                IsComplete = true
            };
        }
    }
}
