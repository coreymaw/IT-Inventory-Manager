using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string ItemCode {get;set;} = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
    }
}