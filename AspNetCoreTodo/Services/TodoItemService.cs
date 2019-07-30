using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreTodo.Models;
using AspNetCoreTodo.Data;

namespace AspNetCoreTodo.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ApplicationDbContext _context;

        public TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            return await _context.Items
                .Where(x => x.IsDone == false)
                .ToArrayAsync();
        }
    }
}