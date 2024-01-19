using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManager.Domain.Dtos;
using InventoryManager.Domain.Models;

namespace InventoryManager.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ItemDto> ConvertToDto(this IEnumerable<Item> items)
        {
            return(from x in items select new ItemDto{
                Id = x.Id,
                ItemCode = x.ItemCode,
                Description = x.ItemCode,
                Model = x.Model
            }).ToList();
        }

    }
}
