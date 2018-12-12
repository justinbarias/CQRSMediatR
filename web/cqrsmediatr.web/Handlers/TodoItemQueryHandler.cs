using cqrsmediatr.domain.models;
using cqrsmediatr.domain.commands;
using cqrsmediatr.persistence;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace cqrsmediatr.web.handlers
{
    public class TodoItemQueryHandler : IRequestHandler<TodoItemQuery, TodoItem>
    {
        private readonly ApiContext _dbContext;
        public TodoItemQueryHandler(ApiContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public Task<TodoItem> Handle(TodoItemQuery query,CancellationToken cancellationToken)
        {
            var todoItem = _dbContext.TodoItem.Where(
                ti => ti.Id == query.Id
            ).FirstOrDefault();
            
            return Task.FromResult(todoItem);
        }
    }
}
