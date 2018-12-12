using cqrsmediatr.domain.models;
using cqrsmediatr.domain.commands;
using cqrsmediatr.persistence;
using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace cqrsmediatr.web.handlers
{
    public class TodoItemCommandHandler : IRequestHandler<TodoItemCommand, TodoItem>
    {
        private readonly ApiContext _dbContext;
        public TodoItemCommandHandler(ApiContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<TodoItem> Handle(TodoItemCommand command,CancellationToken cancellationToken)
        {
            var todoItem = await _dbContext.TodoItem.AddAsync(
                new TodoItem 
                {
                    IsCompleted = false,
                    Title = command.Title,
                    Description = command.Description
                }
            );

            await _dbContext.SaveChangesAsync();

            return todoItem.Entity;
        }
    }
}
