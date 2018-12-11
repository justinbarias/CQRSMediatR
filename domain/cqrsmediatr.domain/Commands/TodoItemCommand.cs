using cqrsmediatr.domain.models;
using System;
using MediatR;

namespace cqrsmediatr.domain.commands
{
    public class TodoItemCommand : IRequest<TodoItem>
    {
        public string Title {get; set;}
        public string Description {get; set;}
    }
}
