using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using cqrsmediatr.domain.commands;
using cqrsmediatr.domain.models;

namespace cqrsmediatr.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        public IMediator _mediator;
        public TodoController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{TodoItemId}")]
        public async Task<IActionResult> GetTodoItem(String TodoItemId, CancellationToken cancellationtoken)
        {
            var todoItem = await _mediator.Send(new TodoItemQuery { Id = TodoItemId}, cancellationtoken);

            return Ok(todoItem);
        }


        [HttpPost]
        public async Task<IActionResult> CreateTodoItem([FromBody] TodoItemCommand command, CancellationToken cancellationtoken)
        {
            var todoItem = await _mediator.Send(command, cancellationtoken);

            return Ok(todoItem);
        }
    }
}
