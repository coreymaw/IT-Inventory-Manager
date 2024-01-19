using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManager.Api.Data;
using InventoryManager.Api.Intefaces;
using InventoryManager.Domain.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Api.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Item> CreateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetItemById(Item item)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Item>> GetItems()
        {
            var items = await _context.Items.ToListAsync();
            return items;
        }
    }
}