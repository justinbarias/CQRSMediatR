using cqrsmediatr.domain.models;
using System;
using MediatR;

namespace cqrsmediatr.domain.commands
{
    public class TodoItemQuery : IRequest<TodoItem>
    {
        public string Id {get; set;}
    }
}
