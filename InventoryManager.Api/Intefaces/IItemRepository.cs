using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManager.Domain.Models;

namespace InventoryManager.Api.Intefaces
{
    public interface IItemRepository
    {
        Task<Item> CreateItem(Item item);
        Task<IEnumerable<Item>> GetItems();
        Task<Item> GetItemById(Item item);
        
    }
}